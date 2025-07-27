using static System.Runtime.InteropServices.JavaScript.JSType;

internal static partial class Problem
{
    //[[0, 0, 1, 1],[1, 0, 1, 0],[1, 1, 0, 0]]
    public static int MatrixScore(int[][] grid)
    {
        int m = grid.Length;        // number of rows
        int n = grid[0].Length;     // number of columns

        // Step 1: Ensure the most significant bit (first column) of every row is 1
        for (int row = 0; row < m; row++)
        {
            if (grid[row][0] == 0)
            {
                // If the first bit is 0, flip the entire row
                // Why? Because the leftmost bit contributes the most in binary
                for (int col = 0; col < n; col++)
                {
                    grid[row][col] ^= 1; // XOR with 1 flips the bit (0↔1)
                    //  -a ^ a = 0(a number XORed with itself cancels out)z
                    // - a ^ 0 = a(XOR with zero returns the number itself)
                }
            }
        }

        // Step 2: For each column (except the first one), decide whether to flip it
        for (int col = 1; col < n; col++)
        {
            int ones = 0;

            // Count how many 1s are in this column
            for (int row = 0; row < m; row++)
            {
                if (grid[row][col] == 1)
                    ones++;
            }

            int zeros = m - ones;

            // If more 0s than 1s, flip the column
            // Why? Because we want to maximize 1s in each column
            if (zeros > ones)
            {
                for (int row = 0; row < m; row++)
                {
                    grid[row][col] ^= 1; // flip the bit
                }
            }
        }

        // Step 3: Compute the binary value of each row and sum them up
        int sum = 0;

        foreach (var row in grid)
        {
            int rowValue = 0;

            foreach (var bit in row)
            {
                rowValue = (rowValue << 1) | bit;
                // Explanation: Shift left (multiply by 2) and add the current bit
            }

            sum += rowValue;
        }

        return sum;
    }
}
