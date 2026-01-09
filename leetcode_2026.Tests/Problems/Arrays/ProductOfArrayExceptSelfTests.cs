using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class ProductOfArrayExceptSelfTests
{
    [Fact]
    public void Test1()
    {
        var solution = new ProductOfArrayExceptSelf();
        var result = solution.Solve([1, 2, 3, 4]);
        Assert.Equal([24, 12, 8, 6], result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new ProductOfArrayExceptSelf();
        var result = solution.Solve([-1, 1, 0, -3, 3]);
        Assert.Equal([0, 0, 9, 0, 0], result);
    }
}
