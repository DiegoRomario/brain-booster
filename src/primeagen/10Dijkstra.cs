namespace primeagen
{
    
    public record GraphEdge(int To, int Weight);

    public static class Dijkstra
    {
        public static List<int>? DijkstraList(int source, int sink, List<GraphEdge>[] graph)
        {
            var seen = new bool[graph.Length];
            var dists = Enumerable.Repeat(double.PositiveInfinity, graph.Length).ToArray();
            var prev = Enumerable.Repeat(-1, graph.Length).ToArray();

            dists[source] = 0;

            while (HasUnvisited(seen, dists))
            {
                int curr = GetLowUnvisited(seen, dists);
                if (curr == -1) break;

                seen[curr] = true;

                foreach (var edge in graph[curr])
                {
                    if (seen[edge.To]) continue;

                    double dist = dists[curr] + edge.Weight;
                    if (dist < dists[edge.To])
                    {
                        dists[edge.To] = dist;
                        prev[edge.To] = curr;
                    }
                }
            }

            if (prev[sink] == -1) return null;

            var path = new List<int>();
            for (int at = sink; at != -1; at = prev[at])
                path.Add(at);

            path.Reverse();
            return path.First() == source ? path : null;
        }

        private static bool HasUnvisited(bool[] seen, double[] dists) =>
            seen.Zip(dists, (s, d) => !s && d < double.PositiveInfinity).Any(v => v);

        private static int GetLowUnvisited(bool[] seen, double[] dists)
        {
            double lowest = double.PositiveInfinity;
            int idx = -1;

            for (int i = 0; i < seen.Length; i++)
            {
                if (seen[i]) continue;
                if (dists[i] < lowest)
                {
                    lowest = dists[i];
                    idx = i;
                }
            }

            return idx;
        }
    }
}