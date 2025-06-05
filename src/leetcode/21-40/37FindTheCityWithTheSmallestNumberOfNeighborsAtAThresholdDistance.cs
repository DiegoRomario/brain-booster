

internal static partial class Problem
{
    public static int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        // Build the graph as an adjacency list
        var graph = new Dictionary<int, List<(int neighbor, int weight)>>();

        for (int i = 0; i < n; i++) graph[i] = [];

        foreach (var edge in edges)
        {
            int from = edge[0], to = edge[1], weight = edge[2];
            graph[from].Add((to, weight));
            graph[to].Add((from, weight));
        }

        int minReachable = int.MaxValue;
        int resultCity = -1;

        for (int city = 0; city < n; city++)
        {
            int reachableCount = Dijkstra(city);
            if (reachableCount <= minReachable) // prefer larger index on tie
            {
                minReachable = reachableCount;
                resultCity = city;
            }
        }

        return resultCity;

        int Dijkstra(int sourceCity)
        {
            int[] minDistance = new int[n];
            Array.Fill(minDistance, int.MaxValue);
            minDistance[sourceCity] = 0;

            // priorityQueue holds pairs (city, distanceSoFar), ordered by distanceSoFar
            var priorityQueue = new PriorityQueue<(int city, int distanceSoFar), int>();
            priorityQueue.Enqueue((sourceCity, 0), 0);

            while (priorityQueue.Count > 0)
            {
                var (currentCity, distanceSoFar) = priorityQueue.Dequeue();

                // 1) Skip outdated entries
                if (distanceSoFar > minDistance[currentCity]) continue;

                // 2) No need to explore beyond the threshold
                if (distanceSoFar > distanceThreshold) break;

                foreach (var (neighborCity, edgeWeight) in graph[currentCity])
                {
                    int newDistance = distanceSoFar + edgeWeight;

                    // Update only if we found a shorter path within the threshold
                    if (newDistance < minDistance[neighborCity] && newDistance <= distanceThreshold)
                    {
                        minDistance[neighborCity] = newDistance;
                        priorityQueue.Enqueue((neighborCity, newDistance), newDistance);
                    }
                }
            }

            int reachableCount = 0;
            for (int city = 0; city < n; city++)
            {
                if (city != sourceCity && minDistance[city] <= distanceThreshold)
                    reachableCount++;
            }

            return reachableCount;
        }
    }
}


