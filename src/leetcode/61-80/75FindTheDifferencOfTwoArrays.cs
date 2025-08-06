internal static partial class Problem
{
    public static IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        List<int> answer1 = [];
        List<int> answer2 = [];

        HashSet<int> h1 = [.. nums1];
        HashSet<int> h2 = [.. nums2];

        foreach (int item in h1)
        {
            if (!h2.Contains(item))
                answer1.Add(item);
        }

        foreach (int item in h2)
        {
            if (!h1.Contains(item))
                answer2.Add(item);
        }

        return [answer1, answer2];
    }

    public static IList<IList<int>> FindDifferenceCleaner(int[] nums1, int[] nums2)
    {
        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        // Using ExceptWith modifies the set in-place and is fast
        var diff1 = new HashSet<int>(set1);
        diff1.ExceptWith(set2);

        var diff2 = new HashSet<int>(set2);
        diff2.ExceptWith(set1);

        return [[.. diff1], [.. diff2]];
    }

    public static IList<IList<int>> FindDifferenceOptimized(int[] nums1, int[] nums2)
    {
        HashSet<int> h1 = [.. nums1];
        HashSet<int> h2 = [.. nums2];

        List<int> answer1 = [];
        List<int> answer2 = [];

        // Process h1 first and modify h2 in-place
        foreach (int item in h1)
        {
            if (h2.Remove(item))
            {
                // item was in both sets, so it's not unique to h1
                continue;
            }
            // item is only in h1
            answer1.Add(item);
        }

        // Remaining items in h2 are unique to h2
        answer2.AddRange(h2);

        return [answer1, answer2];
    }

}
