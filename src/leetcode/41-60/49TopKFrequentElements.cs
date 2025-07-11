internal static partial class Problem
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        var freqMap = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (!freqMap.ContainsKey(num))
                freqMap[num] = 0;

            freqMap[num]++;
        }

        var buckets = new List<int>[nums.Length + 1];
        foreach (var kvp in freqMap)
        {
            int freq = kvp.Value;
            if (buckets[freq] == null)
                buckets[freq] = [];

            buckets[freq].Add(kvp.Key);
        }

        var result = new List<int>();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if (buckets[i] != null)
                result.AddRange(buckets[i]);
        }

        return [.. result.GetRange(0, k)];
    }
}
