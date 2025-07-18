internal static partial class Problem
{
    public static IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
        List<IList<int>> result = [];
        Array.Sort(candidates);
        Comb([], target, 0);

        void Comb(List<int> temp, int remaining, int start)
        {
            if (remaining == 0)
            {
                result.Add([.. temp]);
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (i > start && candidates[i] == candidates[i - 1]) continue;
                if (candidates[i] > remaining) break;

                temp.Add(candidates[i]);
                Comb(temp, remaining - candidates[i], i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        return result;
    }
}
