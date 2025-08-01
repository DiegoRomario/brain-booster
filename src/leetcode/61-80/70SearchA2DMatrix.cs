internal static partial class Problem
{
    public static bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        // Define the search boundaries as if we were working with a 1D array
        int left = 0;
        int right = rows * cols - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            // Flatten a matrix into a 1D array
            // Row is obtained by integer division of mid by number of columns
            int row = mid / cols;

            // Column is obtained by modulo of mid by number of columns
            int col = mid % cols;

            // Access the matrix element using 2D indexing
            int midValue = matrix[row][col];

            // Binary search comparison
            if (midValue == target)
            {
                return true;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }

}
