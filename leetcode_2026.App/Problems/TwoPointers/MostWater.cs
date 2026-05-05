namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Container with most water
/// </summary>
public class MostWater
{
    public int Solve(int[] height)
    {
        int maxArea = 0;

        int i = 0;
        int j = height.Length - 1;
        while (i < j)
        {
            int dist = j - i;
            int area = Math.Min(height[i], height[j]) * dist;

            maxArea = Math.Max(area, maxArea);

            if (height[i] > height[j])
            {
                j--;
            }
            else
            {
                i++;
            }
        }

        return maxArea;
    }
}
