internal static partial class Problem
{
    public static int MaxProfit(int[] prices, int fee)
    {
        if (prices.Length == 0) return 0;

        int cash = 0;
        int hold = -prices[0];

        for (int i = 0; i < prices.Length; i++)
        {
            cash = Math.Max(cash, (prices[i] + hold - fee));
            hold = Math.Max(cash - prices[i], hold);
        }

        return cash;
    }
}
