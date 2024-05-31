namespace L06_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BR1: Vytvoř několik instancí třídy Obdelnik (například 2) a vypiš jejich vlastnosti pomoci metody VypisParameteryObdelniku.
            Console.WriteLine($"Vytváříme obdelník 55,3 x 12");
            var obdelnik1 = new Obdelnik(55.3, 12);
            obdelnik1.VypisParametryObdelniku();

            Console.WriteLine($"Vytváříme obdelník -16 x 12");
            var obdelnik2 = new Obdelnik(-16, 12);
            obdelnik2.VypisParametryObdelniku();

            Console.WriteLine($"Vytváříme obdelník 33,7 x 33,7");
            var obdelnik3 = new Obdelnik(33.7);
            obdelnik3.VypisParametryObdelniku();

            Console.WriteLine($"Vytváříme obdelník 5 x 0");
            var obdelnik4 = new Obdelnik(5, 0);
            obdelnik4.VypisParametryObdelniku();


            // BR2: Napiste program, ktery vytvori obdelnik, vypise jeho velikosti, obsah a obvod.
            Console.WriteLine($"Vytváříme obdelník 55,3 x 12");
            var o5 = new Obdelnik2(55.3, 12);
            Console.WriteLine($"Vytvořený obdelník má šířku {o5.Sirka}, výšku {o5.Vyska}, obsah {Math.Round(o5.Obsah, 1)} a obvod {o5.Obvod}");
            Console.WriteLine($"Obdelník zvětšujeme");
            o5.Zvetsi();
            Console.WriteLine($"Zvětšený obdelník má šířku {o5.Sirka}, výšku {o5.Vyska}, obsah {Math.Round(o5.Obsah)} a obvod {o5.Obvod}");
            Console.WriteLine();

            Console.WriteLine($"Vytváříme obdelník -16 x 12");
            var o6 = new Obdelnik2(-16, 12);
            Console.WriteLine($"Vytvořený obdelník má šířku {o6.Sirka}, výšku {o6.Vyska}, obsah {Math.Round(o6.Obsah)} a obvod {o6.Obvod}");
            Console.WriteLine($"Obdelník zvětšujeme");
            o6.Zvetsi();
            Console.WriteLine($"Zvětšený obdelník má šířku {o6.Sirka}, výšku {o6.Vyska}, obsah {Math.Round(o6.Obsah)} a obvod {o6.Obvod}");
            Console.WriteLine();

            Console.WriteLine($"Vytváříme čtverec 0 x 0");
            var o7 = new Obdelnik2(0);
            Console.WriteLine($"Vytvořený obdelník má šířku {o7.Sirka}, výšku {o7.Vyska}, obsah {Math.Round(o7.Obsah)} a obvod {o7.Obvod}");
            Console.WriteLine($"Obdelník zvětšujeme");
            o7.Zvetsi();
            Console.WriteLine($"Zvětšený obdelník má šířku {o7.Sirka}, výšku {o7.Vyska}, obsah {Math.Round(o7.Obsah)} a obvod {o7.Obvod}");
            Console.WriteLine();
        }
    }
}
