using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class ValidPalindromeTests
{
    [Fact]
    public void Test1()
    {
        var solution = new ValidPalindrome();
        var result = solution.Solve("A man, a plan, a canal: Panama");
        Assert.Equal(true, result);
    }

    [Fact]
    public void Test2()
    {
        var solution = new ValidPalindrome();
        var result = solution.Solve("race a car");
        Assert.Equal(false, result);
    }

    [Fact]
    public void Test3()
    {
        var solution = new ValidPalindrome();
        var result = solution.Solve(" ");
        Assert.Equal(true, result);
    }
}
