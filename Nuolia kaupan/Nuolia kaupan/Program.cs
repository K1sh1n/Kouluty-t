string ReadConsole(string kysymys)
{
    Console.Write($"{kysymys}: ");
    return Console.ReadLine();
}

string karki = ReadConsole("Minkälainen kärki?(puu, teräs vai timantti)");
string pera = ReadConsole("Minkälainen perä?(lehti, kanansulka vai kotkansulka");
int pituus = int.Parse(ReadConsole("Nuolen pituus (60cm - 100cm)"));

Nuoli nuoli = new Nuoli()
{
    karki = Enum.Parse<Karki>(karki),
    pera = Enum.Parse<Pera>(pera),
    pituus = pituus
};
int hinta = nuoli.PalautaHinta();
Console.WriteLine("Tämän nuolen hinta on " + hinta + " kultaa");
class Nuoli {
    public Karki karki;
    public Pera pera;
    public int pituus;
    public int PalautaHinta()
    {
        int karkiHinta = (int)karki;
        int peraHinta = (int)pera;
        int varsiHinta = (int)(0.05 * pituus);
        return karkiHinta + peraHinta + varsiHinta;
    }
}
enum Karki { puu = 3, teräs = 5, timantti = 50 };
enum Pera { lehti = 0, kanansulka = 1, kotkansulka = 5 };



