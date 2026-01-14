using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class _3SumTests
{
    [Fact]
    public void Test1()
    {
        var solution = new _3Sum();
        var result = solution.Solve([-1, 0, 1, 2, -1, -4]);
        Assert.Equal(
            [
                [-1, -1, 2],
                [-1, 0, 1],
            ],
            result
        );
    }

    [Fact]
    public void Test2()
    {
        var solution = new _3Sum();
        var result = solution.Solve([0, 1, 1]);
        Assert.Equal([], result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new _3Sum();
        var result = solution.Solve([0, 0, 0]);
        Assert.Equal(
            [
                [0, 0, 0],
            ],
            result
        );
    }
}
