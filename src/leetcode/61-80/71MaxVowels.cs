internal static partial class Problem
{
    public static int MaxVowels(string s, int k)
    {
        HashSet<char> vowels = ['a', 'e', 'i', 'o', 'u'];
        int max = 0, count = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i])) count++;
            if (i >= k && vowels.Contains(s[i - k])) count--;
            max = Math.Max(max, count);
            if (max == k) return k; // Early exit optimization
        }

        return max;
    }

}
