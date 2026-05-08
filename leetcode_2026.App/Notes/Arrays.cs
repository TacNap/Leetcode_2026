namespace leetcode_2026.App.Problems.Arrays;

/// <summary>
/// </summary>
public class ArrayNotes
{
    public void Copying()
    {
        Console.WriteLine("### Copying Arrays Into Themselves ###");
        // Declare and instantiate a new string[]
        string[] strs = { "one", "two", "three", "four", "five" };
        Console.WriteLine("Array Before Changes:");
        foreach (var str in strs)
        {
            Console.Write($"{str}, ");
        }
        Console.WriteLine();

        // Resize the array to give it one more element
        Array.Resize(ref strs, strs.Length + 1);

        /// Using strs as the source array
        /// Starting from index 2
        /// Copy to strs array
        /// Pasting from index 3
        /// Copy a total of 3 elements
        Array.Copy(strs, 2, strs, 3, 3);
        strs[2] = "NEW";
        Console.WriteLine("Array After Changes:");
        foreach (var str in strs)
        {
            Console.Write($"{str}, ");
        }
    }
}
