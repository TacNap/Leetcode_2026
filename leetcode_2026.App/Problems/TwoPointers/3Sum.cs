namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// 3Sum
/// </summary>
public class _3Sum
{
    public IList<IList<int>> Solve(int[] nums)
    {
        // Solution set
        IList<IList<int>> solution = new List<IList<int>>();
        // Sort the input array first
        nums.Sort();

        // Go to end, leaving room for i and j
        for (int a = 0; a < nums.Length - 2; a++)
        {
            // Skip duplicate values
            if (a > 0 && nums[a] == nums[a - 1])
            {
                continue;
            }
            // Double pointer method begins here
            int i = a + 1;
            int j = nums.Length - 1;
            while (i < j)
            {
                // If target is reached
                int sum = nums[a] + nums[i] + nums[j];
                if (sum == 0)
                {
                    solution.Add(new List<int> { nums[a], nums[i], nums[j] });
                    // Iterate pointers, again skipping duplicate values
                    while (i < j && nums[i] == nums[i + 1])
                        i++;
                    while (i < j && nums[j] == nums[j - 1])
                        j--;
                }

                if (sum < 0)
                {
                    i++; // increment left pointer
                }
                else
                {
                    j--; // increment right pointer
                }
            }
        }
        return solution;
    }
}
