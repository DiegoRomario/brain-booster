namespace leetcode;

internal static partial class Problem
{
    public static int LengthOfLastWord(string s)
    {
        int length = 0;
        int lastCharIndex = s.Length - 1;

        // Skip trailing spaces
        while (lastCharIndex >= 0 && s[lastCharIndex] == ' ')
        {
            lastCharIndex--;
        }

        // Count the length of the last word
        while (lastCharIndex >= 0 && s[lastCharIndex] != ' ')
        {
            length++;
            lastCharIndex--;
        }

        return length;
    }
}
