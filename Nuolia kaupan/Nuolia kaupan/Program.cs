string ReadConsole(string kysymys)
{
    Console.Write($"{kysymys}: ");
    return Console.ReadLine();
}

string karki = ReadConsole("Minkälainen kärki?(puu, teräs vai timantti)");
string pera = ReadConsole("Minkälainen perä?(lehti, kanansulka vai kotkansulka");
int pituus = int.Parse(ReadConsole("Nuolen pituus (60cm - 100cm)"));

Nuoli nuoli = new Nuoli(Enum.Parse<Karki>(karki), Enum.Parse<Pera>(pera), pituus);

int hinta = nuoli.PalautaHinta();
Console.WriteLine("Tämän nuolen hinta on " + hinta + " kultaa");
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




