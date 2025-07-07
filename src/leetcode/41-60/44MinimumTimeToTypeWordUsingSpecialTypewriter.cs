internal static partial class Problem
{
    public static int MinTimeToType(string word)
    {
        int time = 0;

        char current = 'a';

        foreach (var c in word)
        {
            int distance = Math.Abs(c - current);
            int minDistance = Math.Min(distance, 26 - distance);
            time += minDistance + 1;
            current = c;
        }

        return time;
    }
}
