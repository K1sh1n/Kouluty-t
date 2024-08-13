Koordinaatti annettuKoordinaatti = new Koordinaatti(0, -1);
Koordinaatti tarkistusKoordinaatti = new Koordinaatti(1, -1);

annettuKoordinaatti.OnkoVieressa(tarkistusKoordinaatti);

public struct Koordinaatti
{
    public int X { get; private set; }
    public int Y { get; private set; }

    public Koordinaatti(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void OnkoVieressa(Koordinaatti koordinaatti)
    {
        int erotusX = X - koordinaatti.X;
        int erotusY = Y - koordinaatti.Y;

        if (Math.Abs(erotusX) == 0 && Math.Abs(erotusY) == 0)
        {
            Console.WriteLine($"Koordinaatti {X}, {Y} on koordinaatissa {koordinaatti.X}, {koordinaatti.Y}");
        }
        else if (Math.Abs(erotusX) <= 1 && Math.Abs(erotusY) <= 1)
        {
            Console.WriteLine($"Koordinaatti {X}, {Y} on koordinaatin {koordinaatti.X}, {koordinaatti.Y} vieressä");
        }
        else
        {
            Console.WriteLine($"Koordinaatti {X}, {Y} ei ole koordinaatin {koordinaatti.X}, {koordinaatti.Y} vieressä");
        }
    }
}