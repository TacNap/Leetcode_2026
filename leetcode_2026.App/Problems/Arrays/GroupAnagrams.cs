namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Group Anagram
/// </summary>
public class GroupAnagrams
{
    public IList<IList<string>> Solve(string[] strs)
    {
        // Create a dictionary to hold collections of anagrams
        Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        foreach (string str in strs)
        {
            // Create a key that all anagrams would share
            string key = new string(str.OrderBy(c => c).ToArray());
            // If it already exists, add str to the list
            if (anagrams.ContainsKey(key))
            {
                anagrams[key].Add(str);
            }
            // Otherwise, create a new list
            else
            {
                var newList = new List<string>();
                newList.Add(str);
                anagrams.Add(key, newList);
            }
        }

        return new List<IList<string>>(anagrams.Values);
    }
}
