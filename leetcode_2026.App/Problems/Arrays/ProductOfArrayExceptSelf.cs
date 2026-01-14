namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Product of Array Except Self
/// Constraints: Cannot use the division operator.
/// This method uses prefix and suffix arrays, in which we accumulate the product for each element
/// starting from both the front and the back.
/// Thus, the final array is calculated by finding the product of every element before it, and every element after it.
/// This is O(n) because you only iterate through the array 3 times.
/// </summary>
public class ProductOfArrayExceptSelf
{
    public int[] Solve(int[] nums)
    {
        // Create the prefix array. Find the cumulative product starting from [0]
        int[] prefix = new int[nums.Length];
        prefix[0] = nums[0];
        for (int i = 1; i < prefix.Length; i++)
        {
            prefix[i] = prefix[i - 1] * nums[i];
        }
        // Create the suffix array. Find the cumulative product iterating backwards from [Length-1]
        int[] suffix = new int[nums.Length];
        suffix[^1] = nums[^1];
        for (int i = suffix.Length - 2; i >= 0; i--)
        {
            suffix[i] = suffix[i + 1] * nums[i];
        }
        // Create the final array. Populated via `i-1` * `i+1`
        int[] answer = new int[nums.Length];
        answer[0] = suffix[1];
        answer[^1] = prefix[^2];
        for (int i = 1; i < answer.Length - 1; i++)
        {
            answer[i] = prefix[i - 1] * suffix[i + 1];
        }

        return answer;
    }
}
