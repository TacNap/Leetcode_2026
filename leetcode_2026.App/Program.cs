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
