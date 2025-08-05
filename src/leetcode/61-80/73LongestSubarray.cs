internal static partial class Problem
{
    public static int LongestSubarray(int[] nums)
    {
        int zeroes = 0;
        int max = 0;
        int lo = 0;

        for (int hi = 0; hi < nums.Length; hi++)
        {
            if (nums[hi] == 0)
                zeroes++;

            while (zeroes > 1)
            {
                if (nums[lo] == 0)
                    zeroes--;

                lo++;
            }

            int currMax = hi - lo;
            max = Math.Max(max, currMax);
        }

        return max;
    }
}
