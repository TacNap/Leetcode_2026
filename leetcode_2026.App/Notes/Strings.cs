namespace leetcode_2026.App.Problems.Arrays;

using System.Text;

/// <summary>
/// </summary>
public class StringNotes
{
    public void Methods()
    {
        // Remember, Strings and Arrays are immutable.
        string str = "McGruber";
        string substr = str.Substring(2);
        Console.WriteLine($"Mc Who? {substr}");

        // Contains
        string contains = str.Contains("Gruber")
            ? "fucker is in this string"
            : "my dude is not in this string";
        Console.WriteLine(contains);

        int indexOfG = str.IndexOf("G"); // doesn't matter if single or double quote
        Console.WriteLine(str[indexOfG]);

        // Null or empty
        string nuthin = "  ";
        Console.WriteLine($"Is empty? {string.IsNullOrEmpty(nuthin)}");
        nuthin = "";
        Console.WriteLine($"Is empty? {string.IsNullOrEmpty(nuthin)}");

        // Indexing
        substr = str[2..8]; // Starting index (inclusive).. Ending index (exclusive);
        Console.WriteLine(substr);

        // Replacing
        // Again, strings are immutable so these return new strings.
        str = str.Replace('r', 'R'); // Only replaces one char, but multiple instances
        Console.WriteLine(str);
        str = str.PadLeft(10, '0'); // Make the str 10 chars, padding to the left with '0' chars.
        Console.WriteLine(str);

        // Splitting
        str = "a,b,C,DEE,eee";
        string[] alphabet = str.Split(',');
        Console.WriteLine(str);
        string joined = string.Join(", ", alphabet);
        Console.WriteLine(joined);

        string a = "hello";
        string b = "HELLO";
        if (a == b.ToLower())
        {
            Console.WriteLine("Equivalent");
        }

        decimal price = 19.99m;
        a = $"Total: {price:C}";
        Console.WriteLine(a);

        var sb = new StringBuilder();
        for (int i = 0; i < 10; i++)
        {
            sb.Append(i);
        }
        string result = sb.ToString();
        Console.WriteLine(result);
    }

    public void Looping()
    {
        string vowels = "aeiouAEIOU";
        string pattern = "hhhhahhhhhehhhhihhhOhhhhU";

        int count = 0;
        foreach (char c in pattern)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }
        Console.WriteLine($"Count: {count}");

        pattern = "apple";
        string superstring = "asdkljflwkjrapple";
        int upperLimit = superstring.Length - pattern.Length;
        for (int i = 0; i <= upperLimit; i++)
        {
            if (superstring[i] == pattern[0])
            {
                if (superstring.Substring(i, pattern.Length) == pattern)
                {
                    Console.WriteLine("Match Found");
                }
            }
        }
    }
}
