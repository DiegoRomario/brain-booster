using primeagen;


var graph = BuildGraph();
var path = Dijkstra.DijkstraList(0, 6, graph);

if (path == null)
    Console.WriteLine("No path found.");
else
    Console.WriteLine(string.Join(" -> ", path));


static List<GraphEdge>[] BuildGraph()
{
    var list = new List<GraphEdge>[7];

    for (int i = 0; i < list.Length; i++)
        list[i] = [];

    list[0].AddRange([new GraphEdge(1, 3), new GraphEdge(2, 1)]);
    list[1].AddRange([new GraphEdge(0, 3), new GraphEdge(2, 4), new GraphEdge(4, 1)]);
    list[2].AddRange([new GraphEdge(0, 1), new GraphEdge(1, 4)]);
    list[3].AddRange([new GraphEdge(4, 5), new GraphEdge(6, 1)]);
    list[4].AddRange([new GraphEdge(1, 1), new GraphEdge(3, 5), new GraphEdge(5, 2)]);
    list[5].AddRange([new GraphEdge(4, 2), new GraphEdge(6, 1)]);
    list[6].AddRange([new GraphEdge(3, 1), new GraphEdge(5, 1)]);

    return list;
}

