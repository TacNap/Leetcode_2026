// Scratchpad for manual testing
// Run with: dotnet run

using leetcode_2026.App.Problems.Arrays;

var solution = new TrappingRainWater();

var result = solution.Solve([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);
Console.WriteLine(result); // should be 6

result = solution.Solve([4, 2, 0, 3, 2, 5]);
Console.WriteLine(result); // should be 9
