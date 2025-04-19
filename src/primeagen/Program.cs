using primeagen;

string[] maze = [
            "xxxxxxxxxx x",
            "xxxxxxxxxx x",
            "xxxxxxxxxx x",
            "xxxxxxxxxx x",
            "x          x",
            "x xxxxxxxxxx",
        ];

var start = new Point(10, 0);
var end = new Point(1, 5);

var path = Problem.MazeSolver(maze, 'x', start, end);

foreach (var p in path)
{
    Console.WriteLine(p);
}
