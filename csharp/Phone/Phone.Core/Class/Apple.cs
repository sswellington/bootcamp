using Phone.Core.Interfaces;
using Phone.Core.Models;

namespace Phone.Core.Class;

public class Apple : Smartphone, ISmartphone
{
    public Apple(SmartphoneModel phone) : base(phone)
    {
        Phone = phone;
    }
    
    public Apple(string numero, string modelo, string imei, uint memoria) : base(numero, modelo, imei, memoria)
    {
        Phone.Numero = numero;
        Phone.Modelo = modelo;
        Phone.Imei = imei;
        Phone.Memoria = memoria;
    }

    public string InstalarAplicativo(string nomeApp)
    {
        return "Aplicativo" + nomeApp + "instalado com sucesso";
    }
}