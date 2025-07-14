internal static partial class Problem
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int lo = 0;
        double sum = 0;

        while (lo < k)
        {
            sum += nums[lo];
            lo++;
        }

        double avg = sum / k;

        while (lo < nums.Length)
        {
            sum -= nums[lo - k];
            sum += nums[lo];
            double currAvg = sum / k;
            if (currAvg > avg)
                avg = currAvg;
            lo++;
        }

        return avg;
    }
}
