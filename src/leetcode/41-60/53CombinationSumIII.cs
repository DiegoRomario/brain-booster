internal static partial class Problem
{
    public static IList<IList<int>> CombinationSum3(int k, int n)
    {
        List<IList<int>> result = [];

        Comb([], k, n, 1);
        return result;

        void Comb(List<int> curr, int remainingK, int remainingN, int start)
        {
            if (remainingK == 0 && remainingN == 0)
            {
                result.Add([.. curr]);
                return;
            }

            if (remainingK <= 0)
                return;

            for (int i = start; i <= Math.Min(9, remainingN); i++)
            {
                curr.Add(i);
                Comb(curr, remainingK - 1, remainingN - i, i + 1);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}
