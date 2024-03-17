using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Üdvözöllek a Kalandjátékban!");
        Console.WriteLine("Egy sötét erdő mélyén vagy. Válaszd meg, merre szeretnél menni:");
        Console.WriteLine("a) Jobbra fordulj és menj az erdő mélyére.");
        Console.WriteLine("b) Balra fordulj és próbáld megkerülni az erdőt.");

        string choice = Console.ReadLine().ToLower();

        switch (choice)
        {
            case "a":
                ExploreCave();
                break;
            case "b":
                CrossSwamp();
                break;
            default:
                Console.WriteLine("Érvénytelen választás. Próbáld újra!");
                break;
        }
    }

    static void ExploreCave()
    {
        Console.WriteLine("Az erdő mélyére mész és egy barlangot találsz.");
        Console.WriteLine("Belépsz a barlangba. Mit szeretnél tenni?");
        Console.WriteLine("a) Felfedezed a barlangot.");
        Console.WriteLine("b) Visszatérsz az erdőbe.");
        string caveChoice = Console.ReadLine().ToLower();

        switch (caveChoice)
        {
            case "a":
                ExploreInsideCave();
                break;
            case "b":
                Console.WriteLine("Visszatérsz az erdőbe és tovább folytatod a kalandot.");
                break;
            default:
                Console.WriteLine("Érvénytelen választás. Próbáld újra!");
                ExploreCave();
                break;
        }
    }

    static void ExploreInsideCave()
    {
        Console.WriteLine("Felfedezed a barlangot és találsz egy rejtett kincsesládát!");
        Console.WriteLine("Megnyitod a kincsesládát és találsz benne egy varázskövet.");
        Console.WriteLine("Mit szeretnél tenni a varázskővel?");
        Console.WriteLine("a) Megpróbálod használni a varázskövet.");
        Console.WriteLine("b) Visszateszed a kincsesládába a varázskövet.");
        string gemChoice = Console.ReadLine().ToLower();

        switch (gemChoice)
        {
            case "a":
                UseMagicGem();
                break;
            case "b":
                Console.WriteLine("Visszateszed a varázskövet a kincsesládába. Folytatod az utadat az erdőben.");
                break;
            default:
                Console.WriteLine("Érvénytelen választás. Próbáld újra!");
                ExploreInsideCave();
                break;
        }
    }

    static void UseMagicGem()
    {
        Console.WriteLine("Használod a varázskövet és egy titkos ajtó nyílik a barlangban!");
        Console.WriteLine("Belépsz az ajtón és találsz egy másik világot. Gratulálok, nyertél!");
    }

    static void CrossSwamp()
    {
        Console.WriteLine("Megpróbálod megkerülni az erdőt, de egy mocsaras területre tévedsz.");
        Console.WriteLine("Mit szeretnél tenni?");
        Console.WriteLine("a) Keresel egy utat, hogy kijuss az erdőből.");
        Console.WriteLine("b) Megpróbálsz átkelni a mocsáron.");
        string swampChoice = Console.ReadLine().ToLower();

        switch (swampChoice)
        {
            case "a":
                Console.WriteLine("Sikerült megtalálnod az utat, és kijutottál az erdőből. Gratulálok, túlélés!");
                break;
            case "b":
                Console.WriteLine("Megpróbálsz átkelni a mocsáron, de elakadsz. Sajnos, nem sikerült túlélned.");
                break;
            default:
                Console.WriteLine("Érvénytelen választás. Próbáld újra!");
                CrossSwamp();
                break;
        }
    }
}
