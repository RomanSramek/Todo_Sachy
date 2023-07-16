using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace Todo;

public class Tah : IPohyb
{
    public DruhPohybu Druh => DruhPohybu.Tah;

    public Figura Figura { get; private set; }

    public Rada? RadaOd { get; private set; }
    public Sloupec? SloupecOd { get; private set; }

    public Pozice Do { get; private set; }

    public bool Brani { get; private set; }
    public bool Sach { get; private set; }


    public static bool TryParse(string vstup, out Tah tah)
    {
        char t = vstup[0];
        Figura figura;
        if (t == 'V')
        {
            figura = Figura.Vez;
        }

        Regex regex = new("^(?<figura>[VKSDK])?(?<pocatek>[a-h1-9])?[a-h]{1}[1-9]{1}$");
        Match schoda = regex.Match(vstup);
        schoda.Success;
        Group skupina = schoda.Groups["figura"];
        skupina.Value

        tah = null;
        return false;
    }


}
