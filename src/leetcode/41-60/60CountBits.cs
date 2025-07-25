internal static partial class Problem
{
    public static int[] CountBits(int n)
    {
        int[] result = new int[n + 1];

        // Base case: result[0] = 0 (0 has zero 1's)
        for (int i = 1; i <= n; i++)
        {
            // result[i >> 1] is the count for i / 2
            // (i & 1) is 1 if i is odd (last bit is 1), otherwise 0
            result[i] = result[i >> 1] + (i & 1);
        }

        return result;
    }
}
