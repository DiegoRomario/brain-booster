internal static partial class Problem
{
    public static bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var visited = new bool[rooms.Count];
        var stack = new Stack<int>();

        stack.Push(0);
        visited[0] = true;
        int visitedCount = 1;

        while (stack.Count > 0)
        {
            int current = stack.Pop();

            foreach (int key in rooms[current])
            {
                if (!visited[key])
                {
                    visited[key] = true;
                    visitedCount++;
                    stack.Push(key);
                }
            }
        }

        return visitedCount == rooms.Count;
    }
}

