namespace leetcode;

internal static partial class Problem
{
    public static int StrStr(string haystack, string needle)
    {
        int needleSize = needle.Length;
        int haystackSize = haystack.Length;

        for (int haystackIndex = 0; haystackIndex <= haystackSize - needleSize; haystackIndex++)
        {
            for (int needleIndex = 0; needleIndex < needleSize; needleIndex++)
            {
                if (needle[needleIndex] != haystack[haystackIndex + needleIndex]) break;

                if (needleIndex == needleSize - 1) return haystackIndex;
            }
        }

        return -1;
    }
}
