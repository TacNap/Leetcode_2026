# LeetCode Solutions

## Project Structure

- `leetcode_2026.App/` - Solutions go here
- `leetcode_2026.Tests/` - Tests go here

## Adding a New Problem

1. Create solution: `Problems/{Category}/{ProblemName}.cs`
2. Create test: `../leetcode_2026.Tests/Problems/{Category}/{ProblemNameTests}.cs`

## Running Tests

```bash
cd ../leetcode_2026.Tests
dotnet test
```

## Example

**Solution** (`Problems/Arrays/TwoSum.cs`):
```csharp
namespace leetcode_2026.App.Problems.Arrays;

public class TwoSum
{
    public int[] Solve(int[] nums, int target)
    {
        // implementation
    }
}
```

**Test** (`../leetcode_2026.Tests/Problems/Arrays/TwoSumTests.cs`):
```csharp
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
}
```
