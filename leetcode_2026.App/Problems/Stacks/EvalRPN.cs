namespace leetcode_2026.App.Problems.Stacks;

/// <summary>
/// Min Stack
/// </summary>
public class EvalRPN
{
    //["4","13","5","/","+"]
    public int Solve(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        string[] operators = { "+", "-", "*", "/" };

        // Iterate through input array
        foreach (string token in tokens)
        {
            // If token is a number
            if (!Array.Exists(operators, t => t == token))
            {
                stack.Push(int.Parse(token));
            }
            else
            {
                // token is an operator
                int b = stack.Pop();
                int a = stack.Pop();
                int x = 0;

                if (token == "+")
                {
                    x = a + b;
                }
                else if (token == "-")
                {
                    x = a - b;
                }
                else if (token == "*")
                {
                    x = a * b;
                }
                else if (token == "/")
                {
                    x = a / b;
                }

                stack.Push(x);
            }
        }

        return stack.Pop();
    }
}
