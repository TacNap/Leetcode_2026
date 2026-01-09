using leetcode_2026.App.Problems.Arrays;

namespace leetcode_2026.Tests.Problems.Arrays;

public class GroupAnagramsTests
{
    [Fact]
    public void Test1()
    {
        var solution = new GroupAnagrams();
        var result = solution.Solve(["eat", "tea", "tan", "ate", "nat", "bat"]);
        Assert.Equal(
            [
                ["eat", "tea", "ate"],
                ["tan", "nat"],
                ["bat"],
            ],
            result
        );
    }

    [Fact]
    public void Test2()
    {
        var solution = new GroupAnagrams();
        var result = solution.Solve([""]);
        Assert.Equal(
            [
                [""],
            ],
            result
        );
    }
}
