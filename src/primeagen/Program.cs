using static primeagen.Problem;

// Larger Graph Example:
// Graph (Adjacency Matrix):
//   0 -> 1 -> 2 -> 3
//   |           \
//   v             v    
//   4 -> 5 -> 6 -> 7 -> 8

int[][] graph =
[
            [0, 1, 0, 0, 1, 0, 0, 0, 0], // Node 0: connected to 1 and 4
            [0, 0, 1, 0, 0, 0, 0, 0, 0], // Node 1: connected to 2
            [0, 0, 0, 1, 0, 0, 0, 1, 0], // Node 2: connected to 3 and 7
            [0, 0, 0, 0, 0, 0, 0, 0, 0], // Node 3: no outgoing edges
            [0, 0, 0, 0, 0, 1, 0, 0, 0], // Node 4: connected to 5
            [0, 0, 0, 0, 0, 0, 1, 0, 0], // Node 5: connected to 6
            [0, 0, 0, 0, 0, 0, 0, 1, 0], // Node 6: connected to 7
            [0, 0, 0, 0, 0, 0, 0, 0, 1], // Node 7: connected to 8
            [0, 0, 0, 0, 0, 0, 0, 0, 0], // Node 8: no outgoing edges
];


// Let's say we want to find the path from node 0 to node 8
int source = 0;
int needle = 8;

var path = Bfs(graph, source, needle);

if (path != null)
{
    Console.WriteLine("\nPath found:");
    Console.WriteLine(string.Join(" -> ", path));
}
else
{
    Console.WriteLine("\nNo path found.");
}