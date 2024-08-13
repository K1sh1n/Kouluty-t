using System;
using System.Linq;


// Tavara-luokka
class Tavara
{
    public double Paino { get; }
    public double Tilavuus { get; }

    public Tavara(double paino, double tilavuus)
    {
        Paino = paino;
        Tilavuus = tilavuus;
    }
}

// Erilaiset Tavara-luokista periytyvät luokat
class Köysi : Tavara
{
    public Köysi() : base(1.0, 1.5) { }
    public override string ToString()
    {
        return "Köysi";
    }
}

class Miekka : Tavara
{
    public Miekka() : base(5.0, 3.0) { }
    public override string ToString()
    {
        return "Miekka";
    }
}

class Nuoli : Tavara
{
    public Nuoli() : base(0.1, 0.05) { }
    public override string ToString()
    {
        return "Nuoli";
    }
}

class Jousi : Tavara
{

    public Jousi() : base(1.0, 4.0) { }
    public override string ToString()
    {
        return "Jousi";
    }
}

class Vesi : Tavara
{

    public Vesi() : base(2.0, 2.0) { }
    public override string ToString()
    {
        return "Vesi";
    }
}
    class RuokaAnnos : Tavara
    {

        public RuokaAnnos() : base(1.0, 0.5) { }
        public override string ToString()
        {
            return "RuokaAnnos";
        }
    }
    // Reppu-luokka
    class Reppu
    {
        private Tavara[] tavarat;
        private int maxTavaraMaara;
        private double maxKantoPaino;
        private double maxTilavuus;
        private int tavaroidenMaara;
        private double repunPaino;
        private double repunTilavuus;

        public Reppu(int maxTavaraMaara, double maxKantoPaino, double maxTilavuus)
        {
            this.maxTavaraMaara = maxTavaraMaara;
            this.maxKantoPaino = maxKantoPaino;
            this.maxTilavuus = maxTilavuus;
            tavarat = new Tavara[maxTavaraMaara];
        }

        public bool Lisää(Tavara tavara)
        {
            if (tavaroidenMaara < maxTavaraMaara && repunPaino + tavara.Paino <= maxKantoPaino && repunTilavuus + tavara.Tilavuus <= maxTilavuus)
            {
                tavarat[tavaroidenMaara] = tavara;
                tavaroidenMaara++;
                repunPaino += tavara.Paino;
                repunTilavuus += tavara.Tilavuus;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int TavaroidenMäärä
        {
            get { return tavaroidenMaara; }
        }

        public double RepunPaino
        {
            get { return repunPaino; }
        }

        public double RepunTilavuus
        {
            get { return repunTilavuus; }
        }
        public override string ToString()
        {
            return $"Repussa on seuraavat tavarat: {string.Join(",", tavarat.Take(tavaroidenMaara))}";
        }

    }

class Program
{
        static void Main()
        {
            // Luodaan uusi reppu
            Reppu reppu = new Reppu(10, 30.0, 20.0);

            while (true)
            {
                Console.WriteLine($"Repussa on tällä hetkellä {reppu.TavaroidenMäärä}/10, {reppu.RepunPaino}/30, {reppu.RepunTilavuus}/20");
                Console.WriteLine(reppu);
                Console.WriteLine("Mitä haluat lisätä (1: Köysi, 2: Miekka, 3: Nuoli, 4: Jousi, 5: Vesi, 6: Ruoka-annos, 7: Poistu): ");
                int valinta = int.Parse(Console.ReadLine());

                Tavara valittuTavara = null;

                switch (valinta)
                {
                    case 1:
                        valittuTavara = new Köysi();
                        break;
                    case 2:
                        valittuTavara = new Miekka();
                        break;
                    case 3:
                        valittuTavara = new Nuoli();
                        break;
                    case 4:
                        valittuTavara = new Jousi();
                        break;
                    case 5:
                        valittuTavara = new Vesi();
                        break;
                    case 6:
                        valittuTavara = new RuokaAnnos();
                        break;

                    case 7:
                        return;
                    default:
                        Console.WriteLine("Virheellinen valinta!");
                        continue;
                }

                if (reppu.Lisää(valittuTavara))
                {
                    Console.WriteLine("Tavara lisätty reppuun!");
                }
                else
                {
                    Console.WriteLine("Tavaraa ei voitu lisätä. Reppu on täynnä tai tavara ylittäisi maksimipainon/tilavuuden.");
                }
            }
        }
}
