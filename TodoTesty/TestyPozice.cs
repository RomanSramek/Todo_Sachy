using System.Collections;

using Todo;

namespace TodoTesty;

public class TestyPozice
{
    [Test(Description = "Testuje, že se pozice se stejnými sloupci a řadami rovnají.")]
    public void Equals_True([Values]Rada rada, [Values]Sloupec sloupec)
    {
        Pozice sut = new Pozice()
        {
            Rada = rada,
            Sloupec = sloupec,
        };

        bool result = sut.Equals(new()
        {
            Rada = rada,
            Sloupec = sloupec,
        });

        Assert.IsTrue(result);
    }

    public static IEnumerable DejTestovaciPozice()
    {
        foreach (Rada rada in Koordinaty.Rady())
            foreach (Sloupec sloupec in Koordinaty.Sloupce())
                foreach (Rada rada2 in Koordinaty.Rady())
                    foreach (Sloupec sloupec2 in Koordinaty.Sloupce())
                    {
                        if (sloupec != sloupec2 || rada != rada2)
                            yield return new object[] { rada, sloupec, rada2, sloupec2 };
                    }
    }

    [Test(Description = "Testuje, že se pozice s různými sloupci nebo různými řadami nerovnají.")]
    [TestCaseSource(nameof(DejTestovaciPozice))]
    public void Equals_False(Rada rada, Sloupec sloupec,
         Rada rada2, Sloupec sloupec2)
    {
        Pozice sut = new()
        {
            Rada = rada,
            Sloupec = sloupec
        };

        bool result = sut.Equals(new()
        {
            Rada = rada2,
            Sloupec = sloupec2
        });

        Assert.IsFalse(result);
    }
}
