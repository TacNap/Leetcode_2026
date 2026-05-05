// Scratchpad for manual testing
// Run with: dotnet run

using leetcode_2026.App.Problems.Arrays;

var solution = new _3Sum();

var result = solution.Solve([-1, 0, 1, 2, -1, -4]);
Console.WriteLine(
    $"Result: [{string.Join(", ", result.Select(r => $"[{string.Join(", ", r)}]"))}]"
);
result = solution.Solve([0, 0, 0]);
Console.WriteLine(
    $"Result: [{string.Join(", ", result.Select(r => $"[{string.Join(", ", r)}]"))}]"
);
result = solution.Solve([0, 0, 0, 0]);
Console.WriteLine(
    $"Result: [{string.Join(", ", result.Select(r => $"[{string.Join(", ", r)}]"))}]"
);
