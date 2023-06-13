namespace Todo;

public class Pozice : IEquatable<Pozice>
{
    public Sloupec Sloupec { get; init; }
    public Rada Rada { get; init; }

    public bool Equals(Pozice? other)
    {
        throw new NotImplementedException();
    }
}
