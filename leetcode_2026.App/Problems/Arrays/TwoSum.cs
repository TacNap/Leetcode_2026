namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// 1. Two Sum
/// https://leetcode.com/problems/two-sum/
/// </summary>
public class TwoSum
{
    public int[] Solve(int[] nums, int target)
    {
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (seen.TryGetValue(complement, out int j))
            {
                return [j, i];
            }
            seen[nums[i]] = i;
        }

        return [];
    }
}
