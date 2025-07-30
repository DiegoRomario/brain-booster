internal static partial class Problem
{
    public static int ShipWithinDays(int[] weights, int days)
    {
        int low = weights.Max();
        int high = weights.Sum();
        int result = high;

        while (low <= high)
        {
            int capacity = (low + high) / 2;

            if (canShip(capacity))
            {
                result = Math.Min(result, capacity);
                high = capacity - 1;
            }
            else
            {
                low = capacity + 1;
            }
        }

        return result;

        bool canShip(int capacity)
        {
            int ships = 1;
            int currCapacity = capacity;

            foreach (int w in weights)
            {
                if (currCapacity - w < 0)
                {
                    ships += 1;
                    currCapacity = capacity;
                }
                currCapacity -= w;
            }

            return ships <= days;
        }
    }
}
