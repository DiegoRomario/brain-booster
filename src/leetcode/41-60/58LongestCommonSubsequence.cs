internal static partial class Problem
{
    public static int LongestCommonSubsequence(string text1, string text2)
    {
        int[] dp = new int[text1.Length + 1];

        for (int i = 0; i < text2.Length; i++)
        {
            int prev = 0;
            for (int j = 0; j < text1.Length; j++)
            {
                int temp = dp[j + 1];
                if (text2[i] == text1[j])
                {
                    dp[j + 1] = prev + 1;
                }
                else
                {
                    dp[j + 1] = Math.Max(dp[j + 1], dp[j]);
                }
                prev = temp;
            }
        }

        return dp[text1.Length];
    }

    //public int LongestCommonSubsequence(string text1, string text2)
    //{
    //    int[][] dp = new int[text1.Length + 1][];

    //    for (int i = 0; i < dp.Length; i++)
    //    {
    //        dp[i] = new int[text2.Length + 1];
    //    }

    //    for (int row = 1; row < dp.Length; row++)
    //    {
    //        for (int col = 1; col < dp[row].Length; col++)
    //        {
    //            if (text1[row - 1] != text2[col - 1])
    //            {
    //                dp[row][col] = Math.Max(dp[row - 1][col], dp[row][col - 1]);
    //                continue;
    //            }

    //            dp[row][col] = Math.Max(1 + dp[row - 1][col - 1], dp[row][col - 1]);
    //        }
    //    }

    //    return dp[^1][^1];
    //}
}
