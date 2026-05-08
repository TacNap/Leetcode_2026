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
        Console.WriteLine("Array Before Changes: " + string.Join(", ", strs));

        // Resize the array to give it one more element
        Array.Resize(ref strs, strs.Length + 1);

        /// Using strs as the source array
        /// Starting from index 2
        /// Copy to strs array
        /// Pasting from index 3
        /// Copy a total of 3 elements
        Array.Copy(strs, 2, strs, 3, 3);
        strs[2] = "NEW";
        Console.WriteLine("Array After Changes: " + string.Join(", ", strs));
    }

    public void Methods()
    {
        // Finding the index of an item
        string[] tings = { "dragon dagger", "bitcoin", "Hawkmoon", "Plasma Pistol" };
        int hawkmoonIndex = Array.IndexOf(tings, "Hawkmoon");
        Console.WriteLine($"{tings[hawkmoonIndex]}");

        // Resizing an array - requires the ref keyword
        Array.Resize(ref tings, tings.Length + 1);
        tings[^1] = "Supercharged"; // Accesses the last element of the array
    }
}
