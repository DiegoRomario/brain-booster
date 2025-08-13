internal static partial class Problem
{
    public static string RemoveStars(string s)
    {
        var stack = new Stack<char>();

        foreach (var ch in s)
        {
            if (ch == '*')
                stack.Pop();
            else
                stack.Push(ch);
        }

        return new string([.. stack.Reverse()]);
    }

    public static string RemoveStarsSpan(string s)
    {
        var result = new char[s.Length];
        int index = 0;

        foreach (var ch in s)
        {
            if (ch == '*')
                index--;
            else
                result[index++] = ch;
        }

        return new string(result, 0, index);
    }
}
