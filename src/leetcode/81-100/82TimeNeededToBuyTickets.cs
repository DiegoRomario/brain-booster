internal static partial class Problem
{
    public static int TimeRequiredToBuy(int[] tickets, int k)
    {
        int total = 0;
        int target = tickets[k];

        for (int i = 0; i < tickets.Length; i++)
        {
            if (i <= k)
                total += Math.Min(tickets[i], target);
            else
                total += Math.Min(tickets[i], target - 1);
        }

        return total;
    }

}
