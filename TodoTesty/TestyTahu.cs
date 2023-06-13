using System.Collections;

using Todo;

namespace TodoTesty;

public class TestyTahu
{
    public static IEnumerable DejPohybyPesce()
    {
        foreach (Rada rada in Koordinaty.RadyOd(Rada.R3))
            foreach (Sloupec sloupec in Koordinaty.Sloupce())
            {
                yield return new object[] 
                { 
                    $"B {Koordinaty.ToString(sloupec)}{Koordinaty.ToString(rada)}",
                    BarvaFigury.Bila, 
                    sloupec, 
                    rada 
                };
                yield return new object[]
                {
                    $"C {Koordinaty.ToString(sloupec)}{Koordinaty.ToString(rada)}",
                    BarvaFigury.Cerna,
                    sloupec,
                    rada
                };
            }
    }

    [Test]
    [TestCaseSource(nameof(DejPohybyPesce))]
    public void TryParse_PohybBilehoPesce(string text, BarvaFigury barva, Sloupec sloupecDo, Rada radaDo)
    {
        bool vysledek = Tah.TryParse(text, out Tah tah);

        Assert.IsTrue(vysledek);

        Assert.That(tah.Figura, Is.EqualTo(Figura.Pesec));
        Assert.IsFalse(tah.Sach);
        Assert.IsFalse(tah.Brani);

        Assert.That(tah.Barva, Is.EqualTo(barva));
        Assert.That(tah.Do.Sloupec, Is.EqualTo(sloupecDo));
        Assert.That(tah.Do.Rada, Is.EqualTo(radaDo));
    }
}