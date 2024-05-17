namespace L06_OOP
{
    public class Obdelnik2
    {
        // BREAKOUT ROOM 2
        /* Vyuzij tridu Obdelnik z prvniho BR.
           Prepis fieldy Sirka a Vyska na properties.
           Nastavte properties tak, aby je nebylo mozne zmenit po vytvoreni instance.  
           Vytvorte property Obsah, ktera umozni ziskat obsah obdelniku.
           Vytvorte property Obvod, ktera umozni ziskat obvod obdelniku.
           Vytvorte funkci Zvetsi, ktera zvetsi obdelnik o sirku a vysku.
           Zajistete, aby nebylo mozne vytvorit obdelnik o obsahu 0 (vypiste hlasku a nastavte hodnotu na 1).
           Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
        */

        public double Sirka { get; private set; }
        public double Vyska { get; private set; }

        public double Obsah
        {
            get
            {
                return Sirka * Vyska;
            }
        }

        public double Obvod
        {
            get
            {
                return 2 * (Sirka + Vyska);
            }
        }

        public Obdelnik2(double sirka, double vyska)
        {
            sirka = ZkontrolujStranu(sirka, "šířka");
            vyska = ZkontrolujStranu(vyska, "výška");

            Sirka = sirka;
            Vyska = vyska;
        }

        public Obdelnik2(double delkaStrany) : this(delkaStrany, delkaStrany) { }

        public void Zvetsi()
        {
            Sirka += Sirka;
            Vyska += Vyska;
        }

        private double ZkontrolujStranu(double hodnota, string nazev)
        {
            if (hodnota <= 0)
            {
                Console.WriteLine($"Neplatná {nazev}, hodnota {hodnota} změněna na hodnotu 1");
                return 1;
            }

            return hodnota;
        }
    }
}
