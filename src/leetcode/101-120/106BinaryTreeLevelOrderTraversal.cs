internal static partial class Problem
{
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<IList<int>> res = [];

        if (root is null) return [];
        Queue<TreeNode> queue = [];
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int size = queue.Count;
            List<int> level = [];
            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                level.Add(node.val);

                if (node.left is not null)
                    queue.Enqueue(node.left);

                if (node.right is not null)
                    queue.Enqueue(node.right);
            }

            res.Add(level);
        }

        return res;
    }

    public static IList<IList<int>> LevelOrderRecursive(TreeNode root)
    {
        var res = new List<IList<int>>();
        Traverse(root, 0, res);
        return res;

        static void Traverse(TreeNode node, int level, IList<IList<int>> res)
        {
            if (node == null) return;

            // If this is the first time we reach this level, add a new list
            if (res.Count == level)
                res.Add([]);            

            res[level].Add(node.val);

            Traverse(node.left, level + 1, res);
            Traverse(node.right, level + 1, res);
        }
    }
}