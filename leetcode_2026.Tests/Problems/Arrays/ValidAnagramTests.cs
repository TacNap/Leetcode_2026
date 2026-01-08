using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class ValidAnagramTests
{
    [Fact]
    public void Test1()
    {
        var solution = new ValidAnagram();
        var result = solution.Solve("anagram", "nagaram");
        Assert.Equal(true, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new ValidAnagram();
        var result = solution.Solve("rat", "car");
        Assert.Equal(false, result);
    }
}
