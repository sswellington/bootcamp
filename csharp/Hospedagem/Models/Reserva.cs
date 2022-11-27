namespace Dio.Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa>? Hospedes { get; set; }
        public Suite? Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados) => DiasReservados = diasReservados;


        public void CadastrarSuite(Suite suite) => Suite = suite;

        public int ObterQuantidadeHospedes() => Hospedes?.Count ?? 0;
        
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite != null && Suite.Capacidade >= ObterQuantidadeHospedes())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A capacidade disponível é menor do que o número de hóspedes.");
            }
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados;
            if (Suite != null)
            {
                valor *= Suite.ValorDiaria;

                if (DiasReservados > 9)
                {
                    decimal desconto = valor * Convert.ToDecimal(0.10);
                    valor -= desconto;
                }
            } 
            return valor;
        }
    }
}