namespace leetcode;

internal static partial class Problem
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix[..^1];

                if (prefix == "") return prefix;
            }
        }

        return prefix;
    }
}
