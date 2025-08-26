internal static partial class Problem
{
    public static IList<int> Preorder(Node2 root)
    {
        List<int> list = [];

        Helper(root);

        return list;

        void Helper(Node2 node)
        {
            if (node is null)
                return;

            list.Add(node.val);

            foreach (Node2 item in node.children)
            {
                Helper(item);
            }
        }
    }

    public static IList<int> Preorder2(Node2 root)
    {
        if (root == null) return [];

        List<int> result = [];
        Stack<Node2> stack = [];

        stack.Push(root);

        while (stack.Count > 0)
        {
            var curr = stack.Pop();
            result.Add(curr.val);

            for (int i = curr.children.Count - 1; i >= 0; i--)
            {
                stack.Push(curr.children[i]);
            }
        }

        return result;
    }
}