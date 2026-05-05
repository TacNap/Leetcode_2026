// Scratchpad for manual testing
// Run with: dotnet run

using leetcode_2026.App.Problems.Arrays;

var solution = new MostWater();

var result = solution.Solve([1, 8, 6, 2, 5, 4, 8, 3, 7]);
Console.WriteLine(result);
result = solution.Solve([1, 2, 1]);
Console.WriteLine(result);
result = solution.Solve([1, 8, 6, 2, 5, 4, 8, 25, 7]);
Console.WriteLine(result);
