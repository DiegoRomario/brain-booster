internal static partial class Problem
{
    public static IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = [];
        Array.Sort(candidates); 
        Comb ([], target, 0);

        void Comb(List<int> temp, int remaining, int start)
        {   
            if (remaining < 0)
                return;

            if (remaining == 0)
            {
                result.Add([.. temp]);
                return;
            }

            for (int i = start; i < Math.Min(candidates.Length, remaining); i++)
            {
                int curr = candidates[i];
                temp.Add(curr);
                Comb(temp, remaining - curr, i);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        return result; 
    }
}
