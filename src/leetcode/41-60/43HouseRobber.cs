internal static partial class Problem
{
    // [25, 30, 25, 1, 20, 20, 1, 25, 1, 50]
    public static int Rob(int[] nums)
    {
        if (nums is null || nums.Length is 0) return 0;
        if (nums.Length is 1) return nums[0];
        if (nums.Length is 2) return Math.Max(nums[0], nums[1]);

        int[] amount = new int[nums.Length];

        amount[0] = nums[0];
        amount[1] = Math.Max(nums[0], nums[1]);

        for (int i = 2; i < nums.Length; i++)
        {
            amount[i] = Math.Max(nums[i] + amount[i - 2], amount[i -1]);
        }

        return amount[nums.Length - 1];
    }
}
