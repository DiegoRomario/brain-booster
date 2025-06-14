internal static partial class Problem
{
    public static IList<IList<int>> Generate(int numRows)
    {
        List<IList<int>> triangle = [];

        for (int i = 0; i < numRows; i++)
        {
            List<int> row = [];

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    row.Add(1);
                }
                else
                {
                    var sum = triangle[i - 1][j] + triangle[i - 1][j - 1];
                    row.Add(sum);
                }
            }

            triangle.Add(row);
        }

        return triangle;
    }
}



