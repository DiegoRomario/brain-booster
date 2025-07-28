internal static partial class Problem
{
    public static int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        int[] res = new int[spells.Length];

        for (int i = 0; i < spells.Length; i++)
        {
            int low = 0;
            int high = potions.Length;

            while (low < high)
            {
                int mid = (low + high) / 2;

                if ((long)spells[i] * potions[mid] >= success)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }

            res[i] = potions.Length - low;

        }
        return res;
    }
}
