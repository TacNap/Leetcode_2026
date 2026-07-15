namespace leetcode_2026.App.Problems.Stacks;

/// <summary>
/// </summary>
public class StackNotes
{
    public void Properties()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);

        Console.WriteLine("# Stack Properties #");
        Console.WriteLine($"Stack.Capacity: {stack.Capacity}");
        Console.WriteLine($"Stack.Count   : {stack.Count}");
        Console.WriteLine();
    }

    public void Methods()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Clear();

        Console.WriteLine("# Stack Methods #");
        Console.WriteLine($"Stack.Capacity: {stack.Capacity}");
        Console.WriteLine($"Stack.Count   : {stack.Count}");

        stack.Push(10);
        stack.Push(9);
        stack.Push(8);
        Console.WriteLine($"Stack.Contains(T): {stack.Contains(10)}");

        // CopyTo
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Before CopyTo");
        foreach (int i in arr)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();

        Console.WriteLine("After CopyTo");
        stack.CopyTo(arr, 1);
        foreach (int i in arr)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();

        // Ensure Capacity
        Console.WriteLine($"Capacity Before Ensure : {stack.Capacity}");
        Console.WriteLine($"Capacity After Ensure  : {stack.EnsureCapacity(10)}");
    }
}
