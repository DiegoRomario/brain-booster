internal static partial class Problem
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        int[] count = new int[26];

        foreach (char c in magazine)
        {
            count[c - 'a']++;
        }

        foreach (char c in ransomNote)
        {
            count[c - 'a']--;

            if (count[c - 'a'] <= -1) return false;
        }

        return true;
    }
}
