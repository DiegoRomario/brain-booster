internal static partial class Problem
{
    public static int MinSwaps(string s)
    {
        var swaps = 0;
        var left = 0;
        var right = 0;

        for (var i = 0; i < s.Length; i++)
        {
            if (s[i] == '[') left++;
            else right++;

            if (right > left)
            {
                right--;
                left++;
                swaps++;
            }
        }

        return swaps;
    }
}
