var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string Bp1, Bp2, Bp3, Bp4, Bp5, Bp6, Bp7, Bp8;
string BV1, BJ1, BS1,  BD,  BK, BS2, BJ2 ,BV2;

string Èp1, Èp2, Èp3, Èp4, Èp5, Èp6, Èp7, Èp8;
string ÈV1, ÈJ1, ÈS1, ÈD, ÈK, ÈS2, ÈJ2, ÈV2;

// Pùvodní pozice fugurky
String PùvodníPozice;



// Vytvoøení promìnných pro šachové figurky BP1. B je oznaèení barvy. P je zkratka pìšáka a 1 je jeho èíslo.
// BV1 je tedy bíla vìž
// BJ1 bílí jezdec
// BD bílá dáma
// BK bílí král

Bp1 = "A2"; Èp1 = "A7";
Bp2 = "B2"; Èp2 = "B7";
Bp3 = "C2"; Èp3 = "C7";
Bp4 = "D2"; Èp4 = "D7";
Bp5 = "E2"; Èp5 = "E7";
Bp6 = "F2"; Èp6 = "F7";
Bp7 = "G2"; Èp7 = "G7";
Bp8 = "H2"; Èp8 = "H7";
BV1 = "A1"; ÈV1 = "A8";
BJ1 = "B1"; ÈJ1 = "B8";
BS1 = "C1"; ÈS1 = "C8";
BD  = "D1"; ÈD  = "D8";
BK  = "E1"; ÈK  = "E8";
BS2 = "F1"; ÈS2 = "F8";
BJ2 = "G1"; ÈJ2 = "G8";
BV2 = "H1"; ÈV2 = "H8";


app.MapGet("/Bp1", () =>
{
    return Bp1;
});

app.MapGet("/Bp1/{zmenaBp1}", (string zmenaBp1) =>
{
    PùvodníPozice = Bp1;
    // kontrola zda se zadané soøadnice opravdu nachází na šachovnici
    if (zmenaBp1.Length == 2 && zmenaBp1[0] >= 'A' && zmenaBp1[0] <= 'H' && zmenaBp1[1] >= '1' && zmenaBp1[1] <= '8')
    {
        Bp1 = zmenaBp1;
    }
    else
    {
        return "neplatné souøadnice (maximální hodnoty jsou 1-8 a A-H.";
    }

    Dictionary<string, string> promenne = new Dictionary<string, string>();
    // Pøidání promìnných do slovníku
    promenne.Add("Bp1", Bp1);
    promenne.Add("Bp2", Bp2);
    promenne.Add("Bp3", Bp3);
    promenne.Add("Bp4", Bp4);
    promenne.Add("Bp5", Bp5);
    promenne.Add("Bp6", Bp6);
    promenne.Add("Bp7", Bp7);
    promenne.Add("Bp8", Bp8);
    promenne.Add("BV1", BV1);
    promenne.Add("BJ1", BJ1);
    promenne.Add("BS1", BS1);
    promenne.Add("BD"  , BD);
    promenne.Add("BK"  , BK);
    promenne.Add("BS2", BS2);
    promenne.Add("BJ2", BJ2);
    promenne.Add("BV2", BV2);
    // další pokraèování by mìlo být nejspíše do budoucna rozdìleno kvùli pravidlùm ve høe.
    promenne.Add("Èp1", Èp1);
    promenne.Add("Èp2", Èp2);
    promenne.Add("Èp3", Èp3);
    promenne.Add("Èp4", Èp4);
    promenne.Add("Èp5", Èp5);
    promenne.Add("Èp6", Èp6);
    promenne.Add("Èp7", Èp7);
    promenne.Add("Èp8", Èp8);
    promenne.Add("ÈV1", ÈV1);
    promenne.Add("ÈJ1", ÈJ1);
    promenne.Add("ÈS1", ÈS1);
    promenne.Add("ÈD"  , ÈD);
    promenne.Add("ÈK"  , ÈK);
    promenne.Add("ÈS2", ÈS2);
    promenne.Add("ÈJ2", ÈJ2);
    promenne.Add("ÈV2", ÈV2);

    

    // Procházení slovníku
    foreach (var kvp in promenne)
    {
        string nazevPromenne = kvp.Key;
        string hodnotaPromenne = kvp.Value;
        string nazevPromenneSeStejnouHodnotou = "";

        // Kontrola, zda jiná promìnná již má stejnou hodnotu
        bool hodnotaSeOpakuje = promenne.Any(p => p.Key != nazevPromenne && p.Value == hodnotaPromenne);

        if (hodnotaSeOpakuje)
        {
            // uložení názvu promìnné která má již stejné pole do nazevPromenneSeStejnouHodnotou
            nazevPromenneSeStejnouHodnotou = promenne.FirstOrDefault(p => p.Key != nazevPromenne && p.Value == hodnotaPromenne).Key;
            Bp1 = PùvodníPozice;
            return ("Není možné táhnout s  "+nazevPromenne+ " na " +zmenaBp1+ " , na tomto poli je již " +nazevPromenneSeStejnouHodnotou);
        }
        else
        {

            return (nazevPromenne +" se nyní nachází poli " + Bp1);
        }
    }




    //
    return "Zmìna provedena";
});

app.Run();