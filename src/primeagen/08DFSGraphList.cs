namespace primeagen;
internal static partial class Problem
{
    private static bool Walk(WeightedEdge[][] graph, int curr, int needle, bool[] seen, List<int> path)
    {
        if (seen[curr]) return false;

        seen[curr] = true;
        path.Add(curr);

        if (curr == needle) return true;

        var edges = graph[curr];
        for (int i = 0; i < edges.Length; i++)
        {
            if (seen[edges[i].To]) continue;

            if (Walk(graph, edges[i].To, needle, seen, path)) return true;
        }

        path.RemoveAt(path.Count - 1);

        return false;
    }

    public static List<int>? Dfs(WeightedEdge[][] graph, int source, int needle)
    {
        var seen = new bool[graph.Length];
        var path = new List<int>();

        _ = Walk(graph, source, needle, seen, path);

        if (path.Count == 0) return null;

        return path;
    }

    public class WeightedEdge(int to, int weight)
    {
        public int To { get; set; } = to;
        public int Weight { get; set; } = weight;
    }
}
