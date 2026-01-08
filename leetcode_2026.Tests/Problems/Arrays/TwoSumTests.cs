using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class TwoSumTests
{
    [Fact]
    public void Example1()
    {
        var solution = new TwoSum();
        var result = solution.Solve([2, 7, 11, 15], 9);
        Assert.Equal([0, 1], result);
    }

    [Fact]
    public void Example2()
    {
        var solution = new TwoSum();
        var result = solution.Solve([3, 2, 4], 6);
        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void Example3()
    {
        var solution = new TwoSum();
        var result = solution.Solve([3, 3], 6);
        Assert.Equal([0, 1], result);
    }
}
