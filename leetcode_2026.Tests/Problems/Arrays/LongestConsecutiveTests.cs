using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class LongestConsecutiveTests
{
    [Fact]
    public void Test1()
    {
        var solution = new LongestConsecutive();
        var result = solution.Solve([100, 4, 200, 1, 3, 2]);
        Assert.Equal(4, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new LongestConsecutive();
        var result = solution.Solve([0, 0]);
        Assert.Equal(1, result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new LongestConsecutive();
        var result = solution.Solve([]);
        Assert.Equal(0, result);
    }
}
