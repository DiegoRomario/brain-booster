internal static partial class Problem
{
    public static IList<string> BuildArray(int[] target, int n)
    {
        int curr = 0;

        List<string> res = [];

        for (int i = 1; i <= n; i++)
        {
            if (target.Length - 1 < curr) break;

            if (i == target[curr])
            {
                res.Add("Push");
                curr++;
            }
            else
            {
                res.Add("Push");
                res.Add("Pop");
            }
        }

        return res;
    }
}
