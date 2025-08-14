internal static partial class Problem
{
    public static string DecodeString(string s)
    {
        var stack = new Stack<char>();

        foreach (char ch in s)
        {
            if (ch != ']')
            {
                stack.Push(ch);
            }
            else
            {
                // Step 1: get the current string until '['
                var curr = new List<char>();
                while (stack.Count > 0 && stack.Peek() != '[')
                {
                    curr.Insert(0, stack.Pop());
                }

                // Pop the '['
                stack.Pop();

                // Step 2: get the number (might be multi-digit)
                var numChars = new List<char>();
                while (stack.Count > 0 && char.IsDigit(stack.Peek()))
                {
                    numChars.Insert(0, stack.Pop());
                }
                int repeat = int.Parse(new string(numChars.ToArray()));

                // Step 3: push the repeated substring back onto the stack
                var segment = new string(curr.ToArray());
                for (int i = 0; i < repeat; i++)
                {
                    foreach (char c in segment)
                        stack.Push(c);
                }
            }
        }

        // Build the result from the stack
        var resultArray = stack.ToArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}
