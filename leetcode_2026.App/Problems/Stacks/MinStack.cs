namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// Min Stack
/// </summary>
public class MinStack
{
    private List<int> stack;
    private List<int> minStack;

    // Constructor
    public MinStack()
    {
        stack = new List<int>();
        minStack = new List<int>();
    }

    public void Push(int val)
    {
        stack.Add(val);
        int min = minStack.Count == 0 ? val : Math.Min(val, minStack[^1]);
        minStack.Add(min);
    }

    public void Pop()
    {
        stack.RemoveAt(stack.Count - 1);
        minStack.RemoveAt(minStack.Count - 1);
    }

    public int Top()
    {
        return stack[^1];
    }

    public int GetMin()
    {
        return minStack[^1];
    }

    public void Print()
    {
        Console.Write("Stack: ");
        foreach (var i in stack)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();

        Console.Write("MinStack: ");
        foreach (var i in minStack)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
    }
}
