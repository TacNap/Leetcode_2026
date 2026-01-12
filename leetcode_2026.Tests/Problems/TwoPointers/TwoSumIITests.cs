using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class TwoSumIITests
{
    [Fact]
    public void Test1()
    {
        var solution = new TwoSumII();
        var result = solution.Solve([2, 7, 11, 15], 9);
        Assert.Equal([1, 2], result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new TwoSumII();
        var result = solution.Solve([2, 3, 4], 6);
        Assert.Equal([1, 3], result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new TwoSumII();
        var result = solution.Solve([-1, 10], -1);
        Assert.Equal([1, 2], result);
    }
}
