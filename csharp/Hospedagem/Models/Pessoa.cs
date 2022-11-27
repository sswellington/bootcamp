namespace Dio.Hospedagem.Models;

public class Pessoa
{
    public Pessoa(string nome)
    {
        Nome = nome;
        Sobrenome = String.Empty;
    }

    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }

    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
}