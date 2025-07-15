internal static partial class Problem
{
    public static int LongestConsecutive(int[] nums)
    {
        Dictionary<int, bool> set = new(nums.Length);

        for (int i = 0; i < nums.Length; i++)
            set[nums[i]] = false;

        int longestConsecutive = 0;

        foreach ((int num, _) in set)
        {
            if (!set.ContainsKey(num - 1))
            {
                int consecutive = 1;
                while (set.ContainsKey(num + consecutive))
                    consecutive++;

                if (consecutive > longestConsecutive)
                    longestConsecutive = consecutive;
            }
        }

        return longestConsecutive;
    }
}
