// Scratchpad for manual testing
// Run with: dotnet run

using leetcode_2026.App.Problems.Stacks;

var solution = new EvalRPN();
var stackNotes = new StackNotes();

var result = solution.Solve(["4", "13", "5", "/", "+"]);
Console.WriteLine(result); // should be 6

stackNotes.Properties();
stackNotes.Methods();
