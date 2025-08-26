internal static partial class Problem
{
    public static int GoodNodes(TreeNode root)
    {
        return DFS(root, root.val);

        static int DFS(TreeNode node, int currMax)
        {
            if (node == null) return 0;

            int good = node.val >= currMax ? 1 : 0;
            currMax = Math.Max(currMax, node.val);

            return good + DFS(node.left, currMax) + DFS(node.right, currMax);
        }
    }
}