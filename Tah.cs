namespace Todo;

public class Tah : IPohyb
{
    public BarvaFigury Barva { get; private set; }
    public DruhPohybu Druh => DruhPohybu.Tah;

    public Figura Figura { get; private set; }

    public Rada? RadaOd { get; private set; }
    public Sloupec? SloupecOd { get; private set; }

    public Pozice Do { get; private set; }

    public bool Brani { get; private set; }
    public bool Sach { get; private set; }

    public static bool TryParse(string input, out Tah tah)
    {
        throw new NotImplementedException();
    }
}
