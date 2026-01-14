namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// 1. Valid Anagram
/// https://leetcode.com/problems/valid-anagram/description/
/// </summary>
public class ValidAnagram
{
    public bool Solve(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }
        string sortedS = new string(s.OrderBy(c => c).ToArray());
        string sortedT = new string(t.OrderBy(c => c).ToArray());
        return sortedS == sortedT;
    }
}
