using static System.String;

namespace Phone.Core.Models;

public class SmartphoneModel
{
    public string Numero { get; set; } = Empty;
    public string Modelo { get; set; } = Empty;
    public string Imei { get; set; } = Empty;
    public uint Memoria { get; set; } = 0;
}