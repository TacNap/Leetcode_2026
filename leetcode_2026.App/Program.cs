// Scratchpad for manual testing
// Run with: dotnet run

using leetcode_2026.App.Problems.Arrays;

var solution = new TrappingRainWater();

var result = solution.Solve([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]);
Console.WriteLine(result); // should be 6

result = solution.Solve([4, 2, 0, 3, 2, 5]);
Console.WriteLine(result); // should be 9

var stack = new MinStack();

// ["MinStack","push","push","push","getMin","pop","top","getMin"]
stack.Push(-2);
stack.Push(0);
stack.Push(-3);
stack.Print();
Console.WriteLine(stack.GetMin());
stack.Pop();
stack.Print();
Console.WriteLine(stack.Top());
Console.WriteLine(stack.GetMin());

Console.WriteLine($"Max: {Int32.MaxValue}");

var scs = new SCS();
string[] words = { "ab", "bc", "ca" };
string sol = scs.ShortestSuperstring(words);
Console.WriteLine($"Input:  [{string.Join(", ", words)}]");
Console.WriteLine($"Output: \"{sol}\" (length {sol.Length})");

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Console.WriteLine("$$$$ Budgetting $$$$");
// int weeks = 52 - 21;
// int weeklyIncome = 420;
// string[] desc = { "rent", "food", "whoop", "mobile", "claude", "obsidian", "spotify" };
// int[] cost = { 100, 100, 50 / 4, 23 / 4, 32 / 4, 7 / 4, 16 / 4 };
//
// Console.WriteLine($"Total Payments: ${weeklyIncome * weeks}");
// int weeklyCost = 0;
//
// foreach (int c in cost)
// {
//     weeklyCost += c;
// }
// int weeklyAvailable = weeklyIncome - weeklyCost;
// int maxSavings = weeklyAvailable * weeks;
//
// Console.WriteLine($"Weekly Costs: ${weeklyCost}");
// Console.WriteLine($"Weekly Available: ${weeklyAvailable}");
// Console.WriteLine($"MAXIMUM Savings: ${maxSavings}");
//
//
