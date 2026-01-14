namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// 1. Contains Duplicate
/// https://leetcode.com/problems/contains-duplicate/description/
/// </summary>
public class ContainsDuplicate
{
    public bool Solve(int[] nums)
    {
        HashSet<int> set = new HashSet<int>(nums);
        return set.Count == nums.Length ? false : true;
    }
}
