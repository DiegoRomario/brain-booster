using primeagen;
using static primeagen.Problem;

// Graph structure:
//
// (0) --> (1) --> (3)
//  |        |
//  |        v
//  v       (4) --> (5)
// (2) --------^
//
// Edges:
// 0 -> 1 (weight 3), 0 -> 2 (weight 1)
// 1 -> 3 (weight 4), 1 -> 4 (weight 2)
// 2 -> 5 (weight 2)
// 4 -> 5 (weight 1)
//

var graph = new WeightedEdge[][]
{
            [new (1, 3), new (2, 1)],
            [ new (3, 4), new (4, 2)],
            [ new (5, 2)],
            [],
            [new (5, 1)],
            []
};

// 🖨️ Print the graph first
PrintGraph(graph);

int source = 0;
int needle = 5;

var path = Problem.Dfs(graph, source, needle);

if (path != null)
{
    Console.WriteLine("\nPath found:");
    Console.WriteLine(string.Join(" -> ", path));
}
else
{
    Console.WriteLine("\nNo path found.");
}
static void PrintGraph(Problem.WeightedEdge[][] graph)
{
    for (int i = 0; i < graph.Length; i++)
    {
        Console.Write($"Node {i}: ");
        var edges = graph[i];
        for (int j = 0; j < edges.Length; j++)
        {
            Console.Write($"(to: {edges[j].To}, weight: {edges[j].Weight}) ");
        }
        Console.WriteLine();
    }
}