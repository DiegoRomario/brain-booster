internal static partial class Problem
{
    public static int[] AsteroidCollision(int[] asteroids)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < asteroids.Length; i++)
        {
            bool explode = false;

            while (stack.Count > 0 && stack.Peek() > 0 && asteroids[i] < 0)
            {
                if (-asteroids[i] > stack.Peek())
                {
                    stack.Pop();
                    continue;
                }
                else if (-asteroids[i] == stack.Peek())
                {
                    stack.Pop();
                }

                explode = true;
                break;
            }

            if (explode == false)
            {
                stack.Push(asteroids[i]);
            }
        }

        var result = stack.ToArray();
        Array.Reverse(result);
        return result;
    }
}
