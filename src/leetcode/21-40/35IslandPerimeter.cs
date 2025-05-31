internal static partial class Problem
{
    public static int IslandPerimeter(int[][] grid)
    {
        var count = 0;
        
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == 1)
                {
                    count += 4;

                    if (i > 0 && grid[i - 1][j] == 1) count -= 2;

                    if (j > 0 && grid[i][j - 1] == 1) count -= 2;
                }
            }
        }

        return count;
    }
}


