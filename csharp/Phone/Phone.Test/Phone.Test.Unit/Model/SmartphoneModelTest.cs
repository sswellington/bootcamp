using Phone.Core.Models;

namespace Phone.Test.Unit.Model;

public record SmartphoneModelTest
{
    public SmartphoneModel Phone = new()
    {
        Numero = "0000",
        Modelo = "0000",
        Imei = "0000",
        Memoria = 2
    };
}