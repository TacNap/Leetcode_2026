namespace leetcode_2026.App.Problems.Arrays;

using System.Collections;
using System.Linq;

/// <summary>
/// Min Stack
/// </summary>
public class EvalRPN
{
    //["4","13","5","/","+"]
    public int Solve(string[] tokens)
    {
        Stack stack = new Stack(); // Only holds the index of some operator
        string[] operators = { "+", "-", "*", "/" };

        // Push operators to the stack.
        for (int i = tokens.Length - 1; i >= 0; i--)
        {
            if (tokens.Contains(tokens[i]))
            {
                stack.Push(i);
            }
        }

        // While stack != empty, opIndex = Pop()
        while (stack.Count != 0)
        {
            // int opIndex = stack.Pop();
        }
        // string operator = tokens[opIndex];
        // int op1 = tokens[opIndex-2].ToInt();
        // int op2 = tokens[opIndex-1].ToInt();

        return 0;
    }
}
