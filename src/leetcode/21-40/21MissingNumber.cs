internal static partial class Problem
{
    public static int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        double expectedSum = (n + 1) * (n / 2.0); // Using double for precision
        double actualSum = 0;

        for (int i = 0; i < n; i++)
        {
            actualSum += nums[i];
        }

        return (int)(expectedSum - actualSum);
    }
}