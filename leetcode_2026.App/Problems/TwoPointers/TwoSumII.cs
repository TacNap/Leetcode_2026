namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Two Sum II - Input Array is Sorted
/// </summary>
public class TwoSumII
{
    public int[] Solve(int[] numbers, int target)
    {
        if (numbers.Length == 2)
        {
            return [1, 2];
        }
        int i = 0;
        int j = numbers.Length - 1;
        while (true)
        {
            int sum = numbers[i] + numbers[j];
            if (sum == target)
            {
                return [i + 1, j + 1];
            }
            else if (sum < target)
            {
                i++;
                continue;
            }
            else
            {
                j--;
            }
        }
    }
}
