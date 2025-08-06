internal static partial class Problem
{
    public static bool CloseStrings(string word1, string word2)
    {
        if (word1.Length != word2.Length) return false;

        int[] freq1 = new int[26];
        int[] freq2 = new int[26];
        bool[] set1 = new bool[26];
        bool[] set2 = new bool[26];

        for (int i = 0; i < word1.Length; i++)
        {
            int idx1 = word1[i] - 'a'; // calculate how far the current character is from 'a'
            int idx2 = word2[i] - 'a';
            freq1[idx1]++;
            freq2[idx2]++;
            set1[idx1] = true;
            set2[idx2] = true;
        }

        // check if both strings have the same set of characters
        for (int i = 0; i < 26; i++)
        {
            if (set1[i] != set2[i])
                return false;
        }

        Array.Sort(freq1);
        Array.Sort(freq2);

        // check if the frequency matches
        for (int i = 0; i < 26; i++)
        {
            if (freq1[i] != freq2[i])
                return false;
        }

        return true;
    }
}
