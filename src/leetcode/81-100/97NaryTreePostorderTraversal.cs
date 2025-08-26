internal static partial class Problem
{
    public static IList<int> Postorder(Node2 root)
    {
        List<int> list = [];

        DFS(root);

        return list;

        void DFS(Node2 root)
        {
            if (root != null)
            {
                foreach (var child in root.children)
                {
                    DFS(child);
                }
                list.Add(root.val);
            }
        }
    }

    public static IList<int> Postorder2(Node2 root)
    {
        if (root == null) return [];
        IList<int> res = [];
        Stack<Node2> stack = new();
        Stack<bool> visited = new();

        stack.Push(root);
        visited.Push(false);

        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            var visit = visited.Pop();

            if (curr != null)
            {
                if (visit) res.Add(curr.val);
                else
                {
                    stack.Push(curr);
                    visited.Push(true);

                    if (curr.children == null) continue;

                    for (int i = curr.children.Count - 1; i >= 0; i--)
                    {
                        stack.Push(curr.children[i]);
                        visited.Push(false);
                    }
                }
            }
        }
        return res;
    }
}