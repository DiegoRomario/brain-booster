using System.Text;

internal static partial class Problem
{
    public static string FrequencySort(string s)
    {
        if (s.Length <= 2) return s;

        var freqMap = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!freqMap.ContainsKey(s[i]))
                freqMap[s[i]] = 0;

            freqMap[s[i]]++;
        }

        var bucket = new List<char>[s.Length + 1];

        foreach (var item in freqMap)
        {
            var value = item.Value;
            if (bucket[value] == null)
                bucket[value] = [];

            bucket[value].Add(item.Key);
        }

        StringBuilder stringBuilder = new();

        for (int i = bucket.Length - 1; i >= 0; --i)
        {
            if (bucket[i] == null)
                continue;

            foreach (var c in bucket[i])
            {
                for (int j = 0; j < i; ++j) stringBuilder.Append(c);
            }
        }

        return stringBuilder.ToString();
    }

    //public string FrequencySort(string s) // alternative
    //{
    //    Span<(char c, int count)> freq = stackalloc (char, int)[128];
    //    var sortedString = new StringBuilder();

    //    foreach (var ch in s)
    //    {
    //        freq[ch].c = ch;
    //        freq[ch].count++;
    //    }

    //    freq.Sort((a, b) => b.count.CompareTo(a.count));


    //    foreach (var item in freq)
    //    {
    //        sortedString.Append(item.c, item.count);
    //    }
    //    return sortedString.ToString();
    //}
}
