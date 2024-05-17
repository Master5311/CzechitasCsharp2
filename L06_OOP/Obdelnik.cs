
namespace L06_OOP
{
    public class Obdelnik
    {
        // BREAKOUT ROOM 1
        //  Vytvoř třídu Obdelnik (tak, aby byla v samostatnem souboru Obdelnik.cs), která bude mít dva fieldy: Sirka a Vyska.
        //  Vytvoř konstruktor třídy Obdelnik s parametry sirka a vyska.
        //  Přidej do třídy ještě jeden typ konstruktoru pro speciální případ obdelníku(čtverec) s jedním parametrem, který bude volat první konstruktor.
        //  Obdelniku vytvorte funkci Vypis informace, ktery vypise vysku a sirku.
        //  Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.

        private readonly double _sirka;
        private readonly double _vyska;

        public Obdelnik(double sirka, double vyska)
        {
            _sirka = sirka;
            _vyska = vyska;
        }

        public Obdelnik(double delkaStrany) : this(delkaStrany, delkaStrany) { }

        public void VypisParametryObdelniku()
        {
            if (_sirka <= 0 || _vyska <= 0)
            {
                Console.WriteLine($"Neplatný obdelník");
                Console.WriteLine();

                return;
            }

            if (_sirka == _vyska)
            {
                Console.WriteLine($"Délka strany čtverce: {_vyska}");
                Console.WriteLine();

                return;
            }

            Console.WriteLine($"Šířka obdelníku: {_sirka}");
            Console.WriteLine($"Výška obdelníku: {_vyska}");
            Console.WriteLine();
        }
    }
}
