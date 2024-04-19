namespace CzechitasCsharp2;

internal class Program
{
    static void Main()
    {
        Console.Write("Zadej den odjezdu na dovolenou: ");
        string day = Console.ReadLine();

        Console.Write("Zadej měsíc odjezdu na dovolenou: ");
        string month = Console.ReadLine();

        Console.Write("Zadej rok odjezdu na dovolenou: ");
        string year = Console.ReadLine();

        if (!int.TryParse(year, out int intYear) || intYear > 3000)
        {
            Console.Write("Zadej správně rok odjezdu na dovolenou: ");
            year = Console.ReadLine();
        }

        DateTime vacationsStart = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

        TimeSpan timeToVacations = vacationsStart - DateTime.Now;

        if (timeToVacations < TimeSpan.Zero)
        {
            Console.WriteLine("Tuto dovolenou už máš za sebou.");
        }
        else if (timeToVacations < TimeSpan.FromDays(1))
        {
            Console.WriteLine("Nevysedávej u počítače a bež si balit kurfy, za chvíli odjíždíš!");
        }
        else
        {
            Console.WriteLine($"Počet dní do začátku dovolené: {timeToVacations.Days}");
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}
