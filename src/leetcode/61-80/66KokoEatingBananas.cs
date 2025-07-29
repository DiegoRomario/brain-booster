internal static partial class Problem
{
    public static int MinEatingSpeed(int[] piles, int h)
    {
        int low = 1;
        int high = piles.Max();

        while (low < high)
        {
            int mid = (low + high) / 2;

            int hours = 0;
            foreach (int pile in piles)
            {
                hours += pile / mid;
                if (pile % mid > 0)
                    hours += 1;
            }

            if (hours <= h)
                high = mid;
            else
                low = mid + 1;
        }

        return low;
    }
}
