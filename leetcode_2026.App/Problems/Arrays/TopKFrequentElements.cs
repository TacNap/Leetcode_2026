namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Top K Frequent Elements
/// Counts frequencies by using each num value as the key for a dictionary, where the value is the frequency.
/// Then, uses LINQ to sort the dictionary by values, and return the top `k` Keys.
/// </summary>
public class TopKFrequentElements
{
    public int[] Solve(int[] nums, int k)
    {
        var freq = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (freq.ContainsKey(num))
            {
                freq[num]++;
            }
            else
            {
                freq.Add(num, 1);
            }
        }
        return freq.Keys.OrderByDescending(v => freq[v]).Take(k).ToArray();
    }
}
