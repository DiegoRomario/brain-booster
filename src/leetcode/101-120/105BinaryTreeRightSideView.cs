internal static partial class Problem
{
    public static IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        DFS(root, 0);
        return result;

        void DFS(TreeNode node, int depth)
        {
            if (node == null) return;

            // first time reaching this depth -> rightmost node
            if (depth == result.Count)
            {
                result.Add(node.val);
            }

            // visit right first to ensure rightmost priority
            DFS(node.right, depth + 1);
            DFS(node.left, depth + 1);
        }
    }

    public static IList<int> RightSideViewQueue(TreeNode root)
    {
        var result = new List<int>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();

                // last node in this level = rightmost
                if (i == size - 1)
                {
                    result.Add(node.val);
                }

                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
        }

        return result;
    }
}