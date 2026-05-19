namespace leetcode_2026.App.Problems.Arrays;

using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Shortest Common Superstring
/// </summary>
public class SCS
{
    public string ShortestSuperstring(string[] words)
    {
        int n = words.Length;

        // ============================================================
        // STEP 1: Precompute overlaps between every pair of strings.
        // ============================================================
        // overlap[i, j] = the number of characters we save by placing
        // words[j] right after words[i]. Specifically, it's the length
        // of the longest suffix of words[i] that equals a prefix of
        // words[j].
        //
        // Example: words[i] = "abcde", words[j] = "cdefg"
        //   "abcde" ends with "cde", and "cdefg" starts with "cde".
        //   So overlap = 3, and gluing them produces "abcdefg"
        //   (5 + 5 - 3 = 7 characters total).
        // ============================================================
        // 2D array that contains the overlap between each pair of strings
        // This doesn't remove any strings that are substrings of others strings in words[]
        int[,] overlap = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i == j)
                    continue;

                // Try the largest possible overlap first; first match wins.
                int maxPossible = Math.Min(words[i].Length, words[j].Length);
                for (int k = maxPossible; k > 0; k--)
                {
                    if (words[i].EndsWith(words[j].Substring(0, k)))
                    {
                        overlap[i, j] = k;
                        break;
                    }
                }
            }
        }

        // Printing overlap
        PrintArray(overlap);
        Console.WriteLine();

        // ============================================================
        // STEP 2: Set up the dp and parent tables.
        // ============================================================
        // dp[mask, last] = shortest length of a superstring that uses
        //                  exactly the strings whose bits are set in
        //                  `mask`, and that ends with string `last`.
        //
        // parent[mask, last] = which string came just before `last`
        //                      in the best solution for this state.
        //                      Needed to rebuild the actual string at
        //                      the end. -1 means "no previous" — i.e.,
        //                      `last` was the very first string.
        //
        // `mask` is a bitmask: an integer where bit i is 1 if string i
        // has been used. For n strings there are 2^n possible masks,
        // numbered 0 (nothing used) up to (2^n - 1) (everything used).
        // ============================================================
        int fullMask = (1 << n) - 1; // all bits set = every string used = '7' when n = 3
        Console.WriteLine($"fullMask: {fullMask}\n");
        int[,] dp = new int[1 << n, n];
        int[,] parent = new int[1 << n, n];

        // Printing dp
        PrintArray(dp);
        Console.WriteLine();

        PrintArray(parent);
        Console.WriteLine();

        // Initialize everything to "infinity" so any real value beats it.
        // We use MaxValue / 2 so adding to it can't overflow into a negative.
        const int INF = int.MaxValue / 2;
        for (int mask = 0; mask < (1 << n); mask++)
        {
            for (int last = 0; last < n; last++)
            {
                dp[mask, last] = INF;
                parent[mask, last] = -1;
            }
        }

        // Base case: a "superstring" that uses only string i and ends
        // with string i is just words[i] itself. Its mask is (1 << i),
        // i.e., the integer with only bit i set.
        for (int i = 0; i < n; i++)
        {
            dp[1 << i, i] = words[i].Length;
        }

        // ============================================================
        // STEP 3: Fill the dp table, smaller masks before bigger ones.
        // ============================================================
        // Because `mask` grows whenever we add a string, iterating from
        // mask = 1 upward guarantees that any state we look back to
        // (prevMask, which is smaller) has already been computed.
        // ============================================================
        for (int mask = 1; mask < (1 << n); mask++)
        {
            for (int last = 0; last < n; last++)
            {
                // `last` must actually be in this set.
                // (mask & (1 << last)) is nonzero iff bit `last` is set.
                if ((mask & (1 << last)) == 0)
                    continue;

                // The state we came FROM had the same strings used,
                // minus the one we just placed. XOR with (1 << last)
                // flips that bit off, giving us prevMask.
                int prevMask = mask ^ (1 << last);
                if (prevMask == 0)
                    continue; // single-string case, already seeded above

                // Try every possible "previous last" string.
                for (int prev = 0; prev < n; prev++)
                {
                    // `prev` must actually be in the previous set.
                    if ((prevMask & (1 << prev)) == 0)
                        continue;

                    // Cost of arriving here = best cost of prevMask
                    // ending in `prev`, plus the new string's length,
                    // minus whatever we save through overlap.
                    int candidate = dp[prevMask, prev] + words[last].Length - overlap[prev, last];

                    if (candidate < dp[mask, last])
                    {
                        dp[mask, last] = candidate;
                        parent[mask, last] = prev;
                    }
                }
            }
        }

        // ============================================================
        // STEP 4: Pick the best ending string for the full mask.
        // ============================================================
        // dp[fullMask, last] gives the shortest length of a superstring
        // that uses every input string and ends with `last`. We want
        // whichever `last` minimises that.
        // ============================================================
        int bestLast = 0;
        for (int last = 1; last < n; last++)
        {
            if (dp[fullMask, last] < dp[fullMask, bestLast])
            {
                bestLast = last;
            }
        }

        // ============================================================
        // STEP 5: Walk backwards through `parent` to recover the order.
        // ============================================================
        // We know the final state is (fullMask, bestLast). The parent
        // table tells us what came before. Keep stepping back until
        // we hit -1, which marks the very first string.
        // ============================================================
        var order = new List<int>();
        int curMask = fullMask;
        int curLast = bestLast;
        while (curLast != -1)
        {
            order.Add(curLast);
            int prev = parent[curMask, curLast];
            curMask ^= (1 << curLast); // remove curLast from the mask
            curLast = prev;
        }
        order.Reverse(); // we built the list from last → first, so flip it

        // ============================================================
        // STEP 6: Assemble the actual superstring using the order.
        // ============================================================
        // Start with the first word in full. For each subsequent word,
        // skip its overlapping prefix — those characters are already
        // at the end of what we've built so far.
        // ============================================================
        var sb = new StringBuilder();
        sb.Append(words[order[0]]);
        for (int i = 1; i < order.Count; i++)
        {
            int ov = overlap[order[i - 1], order[i]];
            sb.Append(words[order[i]].Substring(ov));
        }

        return sb.ToString();
    }

    static void PrintArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{arr[i, j], 6} "); // pad to 6 chars wide for alignment
            }
            Console.WriteLine();
        }
    }
}
