namespace primeagen;
internal static partial class Problem
{
    public class BinaryNode<T>(T value, BinaryNode<T>? left = null, BinaryNode<T>? right = null)
    {
        public T Value = value;
        public BinaryNode<T>? Left = left;
        public BinaryNode<T>? Right = right;
    }

    public static List<int> PreOrderRecursive(BinaryNode<int>? node)
    {
        var path = new List<int>();
        Walk(node, path);
        return path;
    }

    private static void Walk(BinaryNode<int>? node, List<int> path)
    {
        if (node == null) return;
        path.Add(node.Value);
        Walk(node.Left, path);
        Walk(node.Right, path);
    }

    public static List<int> PreOrderIterative(BinaryNode<int> head)
    {
        var path = new List<int>();
        var stack = new Stack<BinaryNode<int>>();
        BinaryNode<int>? curr = head;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                path.Add(curr.Value);
                stack.Push(curr);
                curr = curr.Left;
            }

            curr = stack.Pop();
            curr = curr.Right;
        }

        return path;
    }


    public static List<int> InOrderRecursive(BinaryNode<int>? node)
    {
        var path = new List<int>();
        WalkInOrder(node, path);
        return path;
    }

    private static void WalkInOrder(BinaryNode<int>? node, List<int> path)
    {
        if (node == null) return;
        WalkInOrder(node.Left, path);
        path.Add(node.Value);
        WalkInOrder(node.Right, path);
    }

    public static List<int> InOrderIterative(BinaryNode<int> head)
    {
        var path = new List<int>();
        var stack = new Stack<BinaryNode<int>>();
        BinaryNode<int>? curr = head;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.Left;
            }

            curr = stack.Pop();
            path.Add(curr.Value);
            curr = curr.Right;
        }

        return path;
    }


    public static List<int> PostOrderRecursive(BinaryNode<int>? node)
    {
        var path = new List<int>();
        WalkPostOrder(node, path);
        return path;
    }

    private static void WalkPostOrder(BinaryNode<int>? node, List<int> path)
    {
        if (node == null) return;
        WalkPostOrder(node.Left, path);
        WalkPostOrder(node.Right, path);
        path.Add(node.Value);
    }

    public static List<int> PostOrderIterative(BinaryNode<int> head)
    {
        var path = new List<int>();
        var stack = new Stack<BinaryNode<int>>();
        BinaryNode<int>? curr = head;
        BinaryNode<int>? lastVisited = null;

        while (curr != null || stack.Count > 0)
        {
            if (curr != null)
            {
                stack.Push(curr);
                curr = curr.Left;
            }
            else
            {
                var peek = stack.Peek();
                if (peek.Right != null && lastVisited != peek.Right)
                {
                    curr = peek.Right;
                }
                else
                {
                    path.Add(peek.Value);
                    lastVisited = stack.Pop();
                }
            }
        }

        return path;
    }


    public static bool Search(BinaryNode<int>? curr, int needle )
    {
        if (curr == null) return false;
        if (curr.Value == needle) return true;
        if (curr.Value < needle) return Search(curr.Right, needle);
        return Search(curr.Left, needle);
    }

    public static bool DFS (BinaryNode<int> head, int needle)
    {
        return Search(head, needle);
    }

}
