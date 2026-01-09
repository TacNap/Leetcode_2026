using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class TopKFrequentElementsTests
{
    [Fact]
    public void Test1()
    {
        var solution = new TopKFrequentElements();
        var result = solution.Solve([1], 1);
        Assert.Equal([1], result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new TopKFrequentElements();
        var result = solution.Solve([1, 1, 1, 2, 2, 3], 2);
        Assert.Equal([1, 2], result);
    }
}
