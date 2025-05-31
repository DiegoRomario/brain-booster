
internal static partial class Problem
{
    public static bool ValidPath(int n, int[][] edges, int source, int destination)
    {
        // Build the adjacency list
        var graph = new List<int>[n];
        for (int i = 0; i < n; i++)
        {
            graph[i] = [];
        }

        foreach (var edge in edges)
        {
            int u = edge[0], v = edge[1];
            graph[u].Add(v);
            graph[v].Add(u); // since it's an undirected graph
        }

        // Keep track of visited nodes
        var visited = new bool[n];

        // Start DFS from the source node
        return DFS(graph, visited, source, destination);
    }

    private static bool DFS(List<int>[] graph, bool[] visited, int current, int destination)
    {
        if (current == destination) return true;

        visited[current] = true;

        foreach (int neighbor in graph[current])
        {
            if (!visited[neighbor])
            {
                if (DFS(graph, visited, neighbor, destination))
                {
                    return true;
                }
            }
        }

        return false;
    }
}


