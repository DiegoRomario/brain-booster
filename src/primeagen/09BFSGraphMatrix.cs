namespace primeagen;
internal static partial class Problem
{
    public static List<int>? Bfs(int[][] graph, int source, int needle)
    {
        var seen = new bool[graph.Length];
        seen[source] = true;

        var prev = new int[graph.Length];
        Array.Fill(prev, -1);

        var queue = new Queue<int>();
        queue.Enqueue(source);

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();

            if (curr == needle)
                break;

            var adjs = graph[curr];
            for (int i = 0; i < adjs.Length; i++)
            {
                if (seen[i] || adjs[i] == 0)
                    continue;

                seen[i] = true;
                prev[i] = curr;
                queue.Enqueue(i);
            }
        }

        if (prev[needle] == -1)
            return null;

        // Reconstruct the path
        var path = new List<int>();
        int at = needle;

        while (at != -1)
        {
            path.Add(at);
            at = prev[at];
        }

        path.Reverse();
        return path;
    }
}
