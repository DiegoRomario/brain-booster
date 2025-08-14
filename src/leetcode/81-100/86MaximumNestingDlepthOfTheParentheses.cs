internal static partial class Problem
{
    public static int MaxDepth(string s)
    {
        int max = 0;
        int left = 0;
        int right = 0;

        foreach (char c in s)
        {
            if (c == '(')
                left++;

            if (c == ')')
            {
                max = Math.Max(max, left - right);
                right++;
            }
        }

        return max;
    }
}
