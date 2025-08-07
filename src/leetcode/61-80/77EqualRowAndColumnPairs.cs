internal static partial class Problem
{
    public static int EqualPairs(int[][] grid)
    {
        var hash = new HashCode();
        hash.Add(10);
        hash.Add(20);
        int finalHash = hash.ToHashCode();

        var rows = new Dictionary<string, int>();
        var answer = 0;

        foreach (var row in grid)
        {
            var rowstring = string.Join(',', row);
            if (!rows.TryAdd(rowstring, 1))
                rows[rowstring]++;
        }

        for (var col = 0; col < grid.Length; col++)
        {
            var column = new int[grid.Length];
            for (var row = 0; row < grid.Length; row++)
                column[row] = grid[row][col];

            var colstring = string.Join(',', column);

            if (rows.TryGetValue(colstring, out var count))
                answer += count;
        }

        return answer;
    }

    public static int EqualPairsFaster(int[][] grid)
    {
        int size = grid.Length;
        int pairs = 0;

        // Dictionary is used instead of HashSet because we need to count duplicates.
        var rowMap = new Dictionary<int, int>();

        // Preprocess all rows and compute their hash codes.
        for (int r = 0; r < size; r++)
        {
            var hash = new HashCode();

            for (int c = 0; c < size; c++)
            {
                // Add each cell in the row to the hash accumulator.
                hash.Add(grid[r][c]);
            }

            // ToHashCode() produces a single int from the sequence of added values.
            int h = hash.ToHashCode();

            // Count how many times each row hash appears.
            rowMap[h] = rowMap.GetValueOrDefault(h) + 1;
        }

        // Now process columns and compare their hash with rows.
        for (int c = 0; c < size; c++)
        {
            var hash = new HashCode();

            for (int r = 0; r < size; r++)
            {
                // Add each cell in the column to the hash accumulator.
                hash.Add(grid[r][c]);
            }

            int h = hash.ToHashCode();

            // If the column hash matches any row hash, count the match(es).
            pairs += rowMap.GetValueOrDefault(h);
        }

        return pairs;
    }

    // Optimized version of EqualPairs using System.HashCode.
    //
    // Why it's faster:
    // - Avoids string.Join and List allocations
    // - HashCode generates a stable and efficient int from a sequence of values
    // - Works well with Dictionary for fast lookup and duplicate tracking
    //
    // Notes on HashCode:
    // - hash.Add(x) accepts any type that implements GetHashCode()
    // - hash.ToHashCode() returns a single int representing the combined hash
    // - Lower memory pressure and faster than creating strings or arrays

}
