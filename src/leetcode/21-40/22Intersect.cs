internal static partial class Problem
{
    public static int[] Intersect(int[] nums1, int[] nums2)
    {
        int[] map = new int[1001];
        List<int> list = [];

        for (int i = 0; i < nums1.Length; i++)
        {
            map[nums1[i]]++;
        }
        for (int i = 0; i < nums2.Length; i++)
        {
            if (map[nums2[i]] > 0)
            {
                list.Add(nums2[i]);
                map[nums2[i]]--;
            }
        }
        return [.. list];
    }
}
