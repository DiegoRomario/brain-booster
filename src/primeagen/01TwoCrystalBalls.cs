namespace primeagen;
internal static partial class Problem
{
    public static int FindBreakingPoint(bool[] floors)
    {
        int jump = (int)Math.Floor(Math.Sqrt(floors.Length));

        int i = jump;

        for (; i < floors.Length; i += jump)
        {
            if (floors[i]) break;
        }

        i -= jump;

        for (int j = 0; j <= jump && i < floors.Length; ++j, ++i)
        {
            if (floors[i]) return i;
        }

        return -1;
    }
}
