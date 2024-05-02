namespace L04_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> cisla = new List<double>
            {
                0.046939913,
                0.295866297,
                0.852489925,
                0.84994766,
                0.96925183,
                0.946275497,
                0.688903175,
                0.553463564,
                0.59628254,
                0.645816929
            };

            // Vypis vsechna cisla na konzoli (nachystej si pro to funkci)
            Vypis(cisla);

            // Vypis na konzoli pocet cisel v seznamu
            VypisPocet(cisla);

            // Pridej cislo 0.5 do seznamu
            Console.WriteLine($"Do seznamu je přidáno číslo 0.5");
            cisla.Add(0.5);         // to samé jako             cisla.Insert(cisla.Count, 0.5);

            // vypis prvni cislo ze seznamu, ktere je vetsi nez 0.8
            // bool jeTam = cisla.Any(x => x > 0.8); // rychlá efektivní kontrola, zda je element v kolekci

            foreach (double x in cisla)
            {
                if (x > 0.8)
                {
                    Console.WriteLine($"První číslo větší než 0.8 je {x}");
                    break;
                }
            }
            // alternativa:
            Console.WriteLine($"První číslo větší než 0.8 je {cisla.First(x => x > 0.8)}");

            // najdi nejvetsi cislo v seznamu, vypis, ktere to je, a odstran ho ze seznamu
            var max = cisla.Max();
            Console.WriteLine($"Největší číslo v seznamu je {max} na pozici {cisla.IndexOf(max)} toto číslo bude odstraněno.");
            cisla.Remove(max);

            // vypis opet vsechna cisla a jejich pocet
            Vypis(cisla);
            VypisPocet(cisla);
        }

        private static void Vypis(List<double> cisla)
        {
            Console.WriteLine("Čísla v seznamu");

            foreach (double c in cisla)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
        }

        private static void VypisPocet(List<double> cisla)
        {
            Console.WriteLine($"Počet čísel v seznamu: {cisla.Count}");
            Console.WriteLine();
        }
    }
}
