internal static partial class Problem
{
    public static int Fib(int n)
    {
        if (n < 2) return n;

        var prevLast = 0;
        var last = 1;
        var current = 0;

        for (int i = 2; i <= n; i++)
        {
            current = prevLast + last;
            prevLast = last;
            last = current;
        }

        return current;
    }
}
