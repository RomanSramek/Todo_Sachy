using System.Collections.Specialized;

namespace Todo;

public class Rosada : IPohyb
{
    public DruhPohybu Druh { get; private set; }

    public static bool TryParse(string input, out Rosada? rosada)
    {
        if (input == "0-0")
        {
            rosada = new Rosada()
            {
                Druh = DruhPohybu.MalaRosada
            };
            return true;
        }
        if (input == "0-0-0")
        {
            rosada = new Rosada()
            {
                Druh = DruhPohybu.VelkaRosada
            };
            return true;
        }
        rosada = null;
        return false;
        
    }
}
