using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class ContainsDuplicateTest
{
    [Fact]
    public void Test1()
    {
        var solution = new ContainsDuplicate();
        // var result = solution.Solve([2, 7, 11, 15], 9);
        var result = solution.Solve([1, 2, 3, 4]);
        Assert.Equal(false, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new ContainsDuplicate();
        var result = solution.Solve([1, 2, 2, 3]);
        Assert.Equal(true, result);
    }
}
