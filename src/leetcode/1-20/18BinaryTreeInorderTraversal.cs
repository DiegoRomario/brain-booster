internal static partial class Problem
{
    public static IList<int> InorderTraversal(TreeNode root)
    {
        List<int> result = [];
        Stack<TreeNode> stack = [];
        TreeNode current = root;

        while (current != null || stack.Count > 0)
        {
            while (current != null)
            {
                stack.Push(current);
                current = current.left;
            }

            current = stack.Pop();
            result.Add(current.val);
            current = current.right;
        }

        return result;
    }

    public static IList<int> InorderTraversalRecursion(TreeNode root)
    {
        var vals = new List<int>();
        InOrderHelper(root, vals);
        return vals;

        static void InOrderHelper(TreeNode root, List<int> vals)
        {
            if (root == null) return;
            InOrderHelper(root.left, vals);
            vals.Add(root.val);
            InOrderHelper(root.right, vals);
        }
    }
}


