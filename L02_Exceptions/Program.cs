namespace L02_Exceptions;

public class Clovek
{
    public string Jmeno;
    public int TelCislo;

    public Clovek(string jmeno, int telCislo)
    {
        if (string.IsNullOrEmpty(jmeno))
        {
            throw new ArgumentNullException(nameof(Jmeno), "Jmeno musi byt vyplneno.");
        }

        if (telCislo.ToString().Length != 9)
        {
            throw new ArgumentException("Telefonni cislo musí mít 9 čísel.", nameof(TelCislo));
        }

        Jmeno = jmeno;
        TelCislo = telCislo;
    }

    public string VypisJmenoACislo()
    {
        return $"{Jmeno}: {TelCislo}";
    }
}
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Program na vytvareni telefonniho seznamu");
        Console.WriteLine("========================================");
        Console.Write("Zadejte jmeno: ");
        string jmeno = Console.ReadLine();
        Console.Write("Zadejte telefonni cislo: ");
        string cislo = Console.ReadLine();

        try
        {
            Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));
            Console.WriteLine(prvniClovek.VypisJmenoACislo());
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine($"Chyba zadanych udaju: {argEx.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Neznama chyba: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Vkladani telefonniho cisla bylo dokonceno.");
        }

        Console.ReadLine();
    }
}
