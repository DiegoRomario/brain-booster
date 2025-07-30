internal static partial class Problem
{
    public static int CountNegatives(int[][] grid)
    {
        int count = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            int low = 0;
            int high = grid[i].Length - 1;
            var arr = grid[i];

            if (arr[low] < 0)
            {
                count += arr.Length;
                continue;
            }

            if (arr[high] > 0)
            {
                continue;
            }
            
            while (low < high)
            {
                int mid = (low + high) / 2;

                if (arr[mid]<0 && arr[mid-1]>=0)
                {
                    count += arr.Length - mid;
                    low = high;
                }
                else if (arr[mid]<0)
                {
                    high = mid;
                }
                else if (arr[mid]>=0)
                {
                    low = mid;
                }
            }

        }
        return count;
    }
}
