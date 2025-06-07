internal static partial class Problem
{
    public static IList<IList<int>> AllPathsSourceTarget(int[][] graph)
    {
        var result = new List<IList<int>>();
        var path = new List<int>();

        Dfs(0);
        return result;

        void Dfs(int node)
        {
            path.Add(node);
            if (node == graph.Length - 1)
            {
                result.Add([.. path]); // copy to avoid reference issues (without copying: result.Add(path))
            }
            else
            {
                foreach (var neighbor in graph[node])
                {
                    Dfs(neighbor);
                }
            }
            path.RemoveAt(path.Count - 1); // backtrack
        }
    }
}


