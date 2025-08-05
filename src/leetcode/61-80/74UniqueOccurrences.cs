internal static partial class Problem
{
    public static bool UniqueOccurrences(int[] arr)
    {
        var frequencyMap = new Dictionary<int, int>();

        foreach (var num in arr)
            frequencyMap[num] = frequencyMap.GetValueOrDefault(num, 0) + 1;

        var seenFrequencies = new HashSet<int>();

        foreach (var freq in frequencyMap.Values)
            if (!seenFrequencies.Add(freq)) return false;

        return true;
    }

    public static bool UniqueOccurrencesFaster(int[] arr)
    {
        // Allocate a fixed-size array (faster than dynamic structures like HashSet)
        // Index i in this array represents if frequency i has been seen.
        // Since the max number of occurrences can't exceed arr.Length, this is safe.
        bool[] seenFrequencies = new bool[arr.Length + 1];

        // Dictionary to count frequencies of each unique number in the input array.
        Dictionary<int, int> frequencyMap = [];

        foreach (int num in arr)
        {
            // TryGetValue avoids two lookups: one for ContainsKey and another for accessing the value.
            // It performs a single lookup, returning the value if present.
            if (!frequencyMap.TryGetValue(num, out int value))
                frequencyMap.Add(num, 1);
            else
                frequencyMap[num] = ++value; // Reuse the retrieved value to increment, saving one dictionary lookup.
        }

        foreach (var pair in frequencyMap)
        {
            // Array access is O(1) and faster than HashSet.Contains() because:
            //  - No hashing is needed.
            //  - No collisions or internal rehashing.
            //  - Better memory locality (CPU cache-friendly).
            if (seenFrequencies[pair.Value]) return false;

            seenFrequencies[pair.Value] = true;
        }

        return true;
    }

}
