internal static partial class Problem
{
    public static int LongestOnes(int[] nums, int k)
    {
        int zeroes = 0;
        int max = 0;
        int low = 0;

        for (int high = 0; high < nums.Length; high++)
        {
            if (nums[high] == 0)
                zeroes++;

            while (zeroes > k)
            {
                if (nums[low] == 0)
                    zeroes--;

                low++;
            }
            int currMax = high - low + 1;
            max = Math.Max(max, currMax);
        }

        return max;
    }
}
