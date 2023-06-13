using Todo;

namespace TodoTesty;

internal static class Koordinaty
{
    private static readonly Rada[] rady = { Rada.R1, Rada.R2, Rada.R3, Rada.R4, Rada.R5, Rada.R6, Rada.R7, Rada.R8 };
    private static readonly Sloupec[] sloupce = { Sloupec.A, Sloupec.B, Sloupec.C, Sloupec.D, Sloupec.E, Sloupec.F, Sloupec.G, Sloupec.H };

    public static IEnumerable<Sloupec> Sloupce() => sloupce;
    public static IEnumerable<Sloupec> SloupceOd(Sloupec od) => sloupce
        .Where(sloupec => sloupec >= od);

    public static IEnumerable<Rada> Rady() => rady;
    public static IEnumerable<Rada> RadyOd(Rada od) => rady
        .Where(rada => rada >= od);

    public static char ToString(Rada rada) => rada switch
    {
        Rada.R1 => '1',
        Rada.R2 => '2',
        Rada.R3 => '3',
        Rada.R4 => '4',
        Rada.R5 => '5',
        Rada.R6 => '6',
        Rada.R7 => '7',
        Rada.R8 => '8',
        _ => throw new ArgumentOutOfRangeException(nameof(rada))
    };

    public static char ToString(Sloupec sloupec) => sloupec switch
    {
        Sloupec.A => 'a',
        Sloupec.B => 'b',
        Sloupec.C => 'c',
        Sloupec.D => 'd',
        Sloupec.E => 'e',
        Sloupec.F => 'f',
        Sloupec.G => 'g',
        Sloupec.H => 'h',
        _ => throw new ArgumentOutOfRangeException(nameof(sloupec))
    };
}
