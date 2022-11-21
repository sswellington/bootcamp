using Phone.Core.Interfaces;
using Phone.Core.Models;

namespace Phone.Core.Class;

public abstract class Smartphone : ISmartphone
{
    public SmartphoneModel Phone { get; set; } = new();

    public Smartphone(SmartphoneModel phone)
    {
        Phone = phone;
    }
    
    public Smartphone(string numero, string modelo, string imei, uint memoria)
    {
        Phone.Numero = numero;
        Phone.Modelo = modelo;
        Phone.Imei = imei;
        Phone.Memoria = memoria;
    }

    public void Ligar() => Console.WriteLine("Ligando...");

    public void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");

    public string InstalarAplicativo(string nomeApp) => String.Empty;
}