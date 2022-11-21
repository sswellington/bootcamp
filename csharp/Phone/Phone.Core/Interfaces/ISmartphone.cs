namespace Phone.Core.Interfaces;

public interface ISmartphone
{
    public void Ligar();

    public void ReceberLigacao();
    
    public string InstalarAplicativo(string nomeApp);
}