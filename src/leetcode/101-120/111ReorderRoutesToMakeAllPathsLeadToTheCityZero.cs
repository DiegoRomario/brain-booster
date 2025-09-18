internal static partial class Problem
{
    public static int MinReorder(int n, int[][] connections)
    {
        // Graph: node -> list of (neighbor, needsReversal)
        var graph = new List<(int, int)>[n];
        for (int i = 0; i < n; i++)
            graph[i] = [];

        foreach (var c in connections)
        {
            int from = c[0], to = c[1];
            graph[from].Add((to, 1)); // original direction (from -> to), may need reversal
            graph[to].Add((from, 0)); // reverse direction (to -> from), already correct
        }

        var visited = new bool[n];
        int changes = 0;

        Dfs(0);
        return changes;

        void Dfs(int node)
        {
            visited[node] = true;
            foreach (var (neighbor, needsReversal) in graph[node])
            {
                if (!visited[neighbor])
                {
                    changes += needsReversal;
                    Dfs(neighbor);
                }
            }
        }
    }
}

