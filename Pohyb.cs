namespace Todo;

public static class Pohyb
{ 
    public static bool TryParse(string input, out IPohyb pohyb)
    {
        if (Tah.TryParse(input, out Tah tah))
        {
            pohyb = tah;
            return true;
        }
        if (Rosada.TryParse(input, out Rosada? rosada))
        {
            pohyb = rosada;
            return true;


        }
        pohyb = null;
        return false;
    }
}
