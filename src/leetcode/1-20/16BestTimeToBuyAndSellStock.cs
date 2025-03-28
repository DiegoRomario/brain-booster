internal static partial class Problem
{
    public static int MaxProfit(int[] prices)
    {
        if (prices.Length < 2) return 0;

        int max = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++) // Start from 1, since 0 is already considered
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            int profit = prices[i] - minPrice;

            if (profit > max)
                max = profit;
        }

        return max;
    }
}