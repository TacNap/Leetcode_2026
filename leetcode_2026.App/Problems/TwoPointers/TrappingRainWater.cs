namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Hard problem of MostWAter
/// </summary>
public class TrappingRainWater
{
    public int Solve(int[] height)
    {
        int[] maxLeft = new int[height.Length];
        int[] maxRight = new int[height.Length];
        int sum = 0;

        // Find the highest value to the left of each element
        int maxNum = 0;
        for (int i = 0; i < maxLeft.Length; i++)
        {
            maxLeft[i] = maxNum;
            maxNum = height[i] > maxNum ? height[i] : maxNum;
        }

        // Find the highest value to the right of each element
        maxNum = 0;
        for (int i = maxRight.Length - 1; i > 0; i--)
        {
            maxRight[i] = maxNum;
            maxNum = height[i] > maxNum ? height[i] : maxNum;
        }

        // Calculate the water held in each element
        for (int i = 0; i < height.Length; i++)
        {
            int water = Math.Min(maxLeft[i], maxRight[i]) - height[i];
            sum += Math.Max(0, water);
        }

        return sum;
    }
}
