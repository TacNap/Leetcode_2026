namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Valid Palindrome
/// </summary>
public class ValidPalindrome
{
    public bool Solve(string s)
    {
        string cleaned = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToLower();
        if (cleaned.Length == 0 || cleaned.Length == 1)
        {
            return true;
        }

        Console.WriteLine(cleaned);
        for (int i = 0; i < cleaned.Length; i++)
        {
            int j = cleaned.Length - 1 - i;
            if (cleaned[i] != cleaned[j])
            {
                return false;
            }
        }

        return true;
    }
}
