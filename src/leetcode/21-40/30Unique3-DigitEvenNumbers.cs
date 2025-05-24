internal static partial class Problem
{
    public static int TotalNumbers(int[] digits)
    {
        var evens = new HashSet<int>();

        for (int a = 0; a < digits.Length; a++)
        {
            for (int b = 0; b < digits.Length; b++)
            {
                for (int c = 0; c < digits.Length; c++)
                {
                    if (a != b && b != c && c != a)
                    {
                        var num = (digits[a] * 100) + (digits[b] * 10) + (digits[c] * 1);
                        if (num % 2 == 0 && digits[a] > 0) evens.Add(num);
                    }
                }
            }
        }
        return evens.Count;
    }
}
