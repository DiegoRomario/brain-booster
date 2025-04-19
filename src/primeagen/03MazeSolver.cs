namespace primeagen;
internal static partial class Problem
{
    private static readonly int[][] DIRECTIONS =
       [
        [1, 0],  // right
        [-1, 0], // left
        [0, 1],  // down
        [0, -1], // up
       ];

    public static List<Point> MazeSolver(string[] maze, char wall, Point start, Point end)
    {
        bool[,] seen = new bool[maze.Length, maze[0].Length]; // y.Lenght, x.Lenght
        List<Point> path = [];
        Walk(maze, wall, start, end, seen, path);
        return path;
    }

    private static bool Walk(string[] maze, char wall, Point curr, Point end, bool[,] seen, List<Point> path)
    {
        // Base cases
        if (curr.X < 0 || curr.X >= maze[0].Length || curr.Y < 0 || curr.Y >= maze.Length)
            return false;
        if (maze[curr.Y][curr.X] == wall)
            return false;
        if (seen[curr.Y, curr.X])
            return false;
        if (curr.X == end.X && curr.Y == end.Y)
        {
            path.Add(new Point(curr.X, curr.Y));
            return true;
        }

        // Mark as seen and add to path
        seen[curr.Y, curr.X] = true;
        path.Add(new Point(curr.X, curr.Y));

        foreach (var dir in DIRECTIONS)
        {
            int newX = curr.X + dir[0];
            int newY = curr.Y + dir[1];
            if (Walk(maze, wall, new Point(newX, newY), end, seen, path))
                return true;
        }

        // Dead end, backtrack
        path.RemoveAt(path.Count - 1);
        return false;
    }
}


public class Point(int x, int y)
{
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public override string ToString() => $"({X}, {Y})";
}

