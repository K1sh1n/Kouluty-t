string ReadConsole(string kysymys)
{
    Console.Write($"{kysymys}: ");
    return Console.ReadLine();
}

string valinta = ReadConsole("Paina 1 jos haluat valmiin nuolen. Paina 2 jos haluat tehdä nuolen itse.");

if(valinta == "1")
{
    string nuolivalinta = ReadConsole(" 1. Aloittelijanuoli  2. Perusnuoli  3. Eliittinuoli");
    switch (nuolivalinta)
    {
        case "1":
            Nuoli nuoli = Nuoli.LuoAloittelijaNuoli();
            int hinta = nuoli.PalautaHinta();
            Console.WriteLine("Tämän nuolen hinta on " + hinta + " kultaa");
            break;
        case "2":
            Nuoli nuoli1 = Nuoli.LuoPerusNuoli();
            int hinta1 = nuoli1.PalautaHinta();
            Console.WriteLine("Tämän nuolen hinta on " + hinta1 + " kultaa");
            break;
        case "3":
            Nuoli nuoli2 = Nuoli.LuoEliittiNuoli();
            int hinta2 = nuoli2.PalautaHinta();
            Console.WriteLine("Tämän nuolen hinta on " + hinta2 + " kultaa");
            break;
    }
}
else if(valinta == "2")
{
    string karki = ReadConsole("Minkälainen kärki?(puu, teräs vai timantti)");
    string pera = ReadConsole("Minkälainen perä?(lehti, kanansulka vai kotkansulka");
    int pituus = int.Parse(ReadConsole("Nuolen pituus (60cm - 100cm)"));

    Nuoli nuoli = new Nuoli(Enum.Parse<Karki>(karki), Enum.Parse<Pera>(pera), pituus);
    int hinta = nuoli.PalautaHinta();
    Console.WriteLine("Tämän nuolen hinta on " + hinta + " kultaa");
}



class Nuoli {
    public Karki Karki
    {
        get;
    }
    public Pera Pera
    {
        get;
    }
    public int Pituus {
        get;}
    public Nuoli(Karki karki, Pera pera, int pituus)
    {
        Karki = karki;
        Pera = pera;
        Pituus = pituus;
    }

    public static Nuoli LuoAloittelijaNuoli()
    {
        return new Nuoli(Karki.puu, Pera.kanansulka, 70);
    }

    public static Nuoli LuoPerusNuoli()
    {
        return new Nuoli(Karki.teräs, Pera.kanansulka, 85);
    }

    public static Nuoli LuoEliittiNuoli()
    {
        return new Nuoli(Karki.timantti, Pera.kotkansulka, 100);
    }
    public int PalautaHinta()
    {
        int karkiHinta = (int)Karki;
        int peraHinta = (int)Pera;
        int varsiHinta = (int)(0.05 * Pituus);
        return karkiHinta + peraHinta + varsiHinta;
    }
}


enum Karki { puu = 3, teräs = 5, timantti = 50 };
enum Pera { lehti = 0, kanansulka = 1, kotkansulka = 5 };




