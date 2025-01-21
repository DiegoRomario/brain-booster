namespace leetcode;

internal static partial class Problem
{
    public static bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0) return false;

                char topItem = stack.Pop();

                if ((c == ')' && topItem != '(' ||
                    c == '}' && topItem != '{' ||
                    c == ']' && topItem != '['))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}
