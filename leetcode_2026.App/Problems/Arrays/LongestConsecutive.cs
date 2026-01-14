namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Longest Consecutive
/// </summary>
public class LongestConsecutive
{
    public int Solve(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        HashSet<int> set = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in set)
        {
            if (!set.Contains(num - 1))
            {
                int current = num;
                int streak = 1;

                while (set.Contains(current + 1))
                {
                    current++;
                    streak++;
                }

                longest = longest >= streak ? longest : streak;
            }
        }

        return longest;
    }
}
