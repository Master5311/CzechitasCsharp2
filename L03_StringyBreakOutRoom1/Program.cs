string separator = new string('=', 60);

//Ukol - Obratte poradi stringu
Console.WriteLine("Obratte poradi stringu");
Console.WriteLine(separator);

string palindrom = "Kuna nese nanuk";

Console.WriteLine($"Obraceny string: {ReverseString(palindrom)}");



static string ReverseStringSecondAlternative(string palindrom)
{
    string output = "";

    for (int i = 1; i <= palindrom.Length; i++)
    {
        output += palindrom[palindrom.Length - i];
    }
    return output;
}

# region Alternative
Console.WriteLine($"Obreaceny string alternativni metoda: {ReverseStringSecondAlternative(palindrom)}");
Console.WriteLine($"{separator}{Environment.NewLine}");

static string ReverseString(string palindrom)
    => string.Concat(palindrom.Reverse());
#endregion

//=======================================================================

//Ukol - Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy
Console.WriteLine("Napiste funkci, ktera umi detekovat, ze se jedna o palindrom (zatim jen u slov) a pak z pole vypiste jen palindromy");
Console.WriteLine(separator);

string[] slova = new string[] { "kajak", "program", "rotor", "Czechitas", "madam", "Jarda", "radar", "nepotopen" };

PrintPalindrome(slova);

static void PrintPalindrome(string[] input)
{
    Console.Write("Palindromy: ");
    for (int i = 0; i < input.Length; i++)
    {
        string currentWord = input[i];
        if (IsPalindrome(currentWord))
        {
            Console.Write($"{currentWord},");
        }
    }

    Console.Write("\n");
}


static bool IsPalindrome(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        throw new ArgumentException("Input can not be null or white space or empty", nameof(input));
    }

    for (int i = 1; i <= input.Length; i++)
    {
        if (input[i - 1] != input[input.Length - i])
        {
            return false;
        }
    }

    return true;
}

#region Alternative

Console.WriteLine($"Palindromy alternativni metoda: {string.Join(", ", slova.Where(IsPalindromeAlternative))}");
Console.WriteLine($"{separator}{Environment.NewLine}");

static bool IsPalindromeAlternative(string input)
    => string.IsNullOrWhiteSpace(input) ?
    throw new ArgumentException("Input can not be null or white space or empty", nameof(input))
    :
    input
    .Select(c => c)
    .SequenceEqual(input.Reverse());
#endregion


//=======================================================================

//Ukol - opravte v tomto textu omylem zapnuty Caps Lock

Console.WriteLine("opravte v tomto textu omylem zapnuty Caps Lock");
Console.WriteLine(separator);

string capsLock = "jAK mICROSOFT wORD POZNA ZAPNUTY cAPSLOCK";

Console.WriteLine($"Capslock oprava: {FixCapsLock(capsLock)}");

string FixCapsLock(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        throw new ArgumentException("Input can not be null or white space or empty", nameof(input));
    }

    string fixedString = "";

    for (int i = 0; i < input.Length; i++)
    {
        if (char.IsUpper(input[i]))
        {
            fixedString += char.ToLower(input[i]);
        }
        else if (char.IsLower(input[i]))
        {
            fixedString += char.ToUpper(input[i]);
        }
        else
        {
            fixedString += input[i];
        }
    }

    return fixedString;
}
#region Alternative
Console.WriteLine($"Capslock oprava alternativni: {FixCapsLockAlternative(capsLock)}");
Console.WriteLine($"{separator}{Environment.NewLine}");

string FixCapsLockAlternative(string input)
    => string.IsNullOrWhiteSpace(input) ?
    throw new ArgumentException("Input can not be null or white space or empty", nameof(input))
    :
    string.Concat(input
    .Select(c => char.IsUpper(c) ? char.ToLower(c) :
    char.IsLower(c) ? char.ToUpper(c) : c));
#endregion

//=======================================================================

//Ukol - rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. 
Console.WriteLine("rozsifrujte tuto zpravu - text byl zasifrovan tak, ze jsme kazde pismeno posunuli o jedno doprava: 'a' -> 'b'. ");
Console.WriteLine(separator);

string sifra = "Wzcpsob!qsbdf!.!hsbuvmvkj!b!ktfn!ob!Ufcf!qztoz";

Console.WriteLine($"Sifra: {Decrypt(sifra)}");

static string Decrypt(string input)
{
    if (string.IsNullOrWhiteSpace(input))
    {
        throw new ArgumentException("Input can not be null or white space or empty", nameof(input));
    }

    string output = "";

    for (int i = 0; i < input.Length; i++)
    {
        output += (char)(input[i] - 1);
    }

    return output;
}


#region Alternativa
Console.WriteLine($"Sifra alternativa: {DecryptAlternative(sifra)}");
Console.WriteLine(separator);

static string DecryptAlternative(string encryptedInput)
    => string.Concat(encryptedInput.Select(c => (char)(c - 1)));
#endregion
