namespace Todo;

public class Pozice : IEquatable<Pozice>
{
    public Sloupec Sloupec { get; init; }
    public Rada Rada { get; init; }

    public bool Equals(Pozice? druhy)
    {
        return Sloupec == druhy.Sloupec && Rada == druhy.Rada;
    }
}
