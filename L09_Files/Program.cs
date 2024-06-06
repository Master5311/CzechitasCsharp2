using System.Xml.Serialization;

#region Breakout room 1

List<Clovek> telefonniSeznam = new List<Clovek>
{
    new Clovek("Jarda", "Kadlec", 777123456),
    new Clovek("Honza", "Kratochvila", 777987654),
    new Clovek("Petr", "Novak", 778111222)
};

//1. Vytvorte slozku TelefonniSeznam v adresari Appdata pro konkretniho uzivatele

var adresar = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TelefonniSeznam");
if (!Directory.Exists(adresar))
{
    Directory.CreateDirectory(adresar);
}

//2. Do souboru telefonniSeznam.csv ulozte obsah seznamu telefonniSeznam tak,
//   ze kazdy zaznam bude na jednom radku a oddelene budou carkami

string soubor = Path.Combine(adresar, "telefonniSeznam.csv");
File.WriteAllText(soubor, "Jmeno; Prijmeni; TelCislo" + Environment.NewLine);

var radky = telefonniSeznam.Select(clovek => $"{clovek.Jmeno}; {clovek.Prijmeni}; {clovek.TelCislo}");
File.AppendAllLines(soubor, radky);

//3. Napiste cyklus, ktery soubor precte a zpatky ho ulozi do noveho seznamu

if (File.Exists(soubor))
{
    var nactenoZeSouboru = File.ReadAllLines(soubor);
    foreach (var radek in nactenoZeSouboru)
    {
        Console.WriteLine(radek);
    }
}
else
{
    Console.WriteLine("Soubor nenalezen");
}

#endregion

#region Breakout room 2
List<Clovek2> telefonniSeznam2 = new List<Clovek2>
{
    new Clovek2("Jarda", "Kadlec", 777123456),
    new Clovek2("Honza", "Kratochvila", 777987654),
    new Clovek2("Petr", "Novak", 778111222)
};


//1. Upravte tridu Clovek, aby byla serializovatelna
//2. Ulozte cely telefonni seznam do XML pomoci serializeru a StreamWriteru
var adresar2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "TelefonniSeznam");
if (!Directory.Exists(adresar2))
{
    Directory.CreateDirectory(adresar2);
}
string soubor2 = Path.Combine(adresar2, "telefonniSeznam.xml");

XmlSerializer serializer = new XmlSerializer(typeof(List<Clovek2>));
using (StreamWriter writer = new StreamWriter(soubor2))
{
    serializer.Serialize(writer, telefonniSeznam2);
}

//3. Nactete cely telefonni seznam ze souboru XML pomoci deserializeru a StreamReaderu
using (StreamReader reader = new StreamReader(soubor2))
{
    var nactenoZeSouboru = serializer.Deserialize(reader) as List<Clovek2>;
    foreach (var clovek in nactenoZeSouboru)
    {
        Console.WriteLine($"{clovek.Jmeno} {clovek.Prijmeni} : {clovek.TelCislo}");
    }
}
#endregion

public class Clovek
{
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public int TelCislo { get; set; }

    public Clovek(string jmeno, string prijmeni, int telCislo)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        TelCislo = telCislo;
    }
}

[Serializable]
public class Clovek2
{
    public string Jmeno { get; set; }
    public string Prijmeni { get; set; }
    public int TelCislo { get; set; }

    public Clovek2(string jmeno, string prijmeni, int telCislo)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
        TelCislo = telCislo;
    }

    private Clovek2() { } //serialization
}