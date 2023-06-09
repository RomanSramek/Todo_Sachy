var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

string Bp1, Bp2, Bp3, Bp4, Bp5, Bp6, Bp7, Bp8;
string BV1, BJ1, BS1,  BD,  BK, BS2, BJ2 ,BV2;

string Èp1, Èp2, Èp3, Èp4, Èp5, Èp6, Èp7, Èp8;
string ÈV1, ÈJ1, ÈS1, ÈD, ÈK, ÈS2, ÈJ2, ÈV2;



// Vytvoøení promìnných pro Šachové figurky BP1 je BílíPìšák1 atd...
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
    Bp1 = zmenaBp1;

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
    promenne.Add("BD", BD);
    promenne.Add("BK", BK);
    promenne.Add("BS2", BS2);
    promenne.Add("BJ2", BJ2);
    promenne.Add("BV2", BV2);
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
    promenne.Add("ÈD", ÈD);
    promenne.Add("ÈK", ÈK);
    promenne.Add("ÈS2", ÈS2);
    promenne.Add("ÈJ2", ÈJ2);
    promenne.Add("ÈV2", ÈV2);

    // Pøidej další promìnné

    // Procházení slovníku
    foreach (var kvp in promenne)
    {
        string nazevPromenne = kvp.Key;
        string hodnotaPromenne = kvp.Value;

        // Kontrola, zda jiná promìnná již má stejnou hodnotu
        bool hodnotaSeOpakuje = promenne.Any(p => p.Key != nazevPromenne && p.Value == hodnotaPromenne);

        if (hodnotaSeOpakuje)
        {
            Console.WriteLine("Není možné nastavit hodnotu promìnné " + nazevPromenne + ", protože již existuje jiná promìnná s touto hodnotou.");
        }
        else
        {
            Console.WriteLine("Hodnota promìnné " + nazevPromenne + " je unikátní.");
        }
    }




    //
    return "Zmìna provedena";
});

app.Run();