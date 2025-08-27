internal static partial class Problem
{
    public static int LongestZigZag(TreeNode root)
    {
        int maxLength = 0;
        if (root == null) return 0;

        DFS(root.left, true, 1);
        DFS(root.right, false, 1);

        return maxLength;

        void DFS(TreeNode node, bool isLeft, int length)
        {
            if (node == null) return;

            // Update global maximum
            maxLength = Math.Max(maxLength, length);

            if (isLeft)
            {
                // last move was left, so next should be right
                DFS(node.right, false, length + 1);
                DFS(node.left, true, 1); // reset if we continue same direction
            }
            else
            {
                // last move was right, so next should be left
                DFS(node.left, true, length + 1);
                DFS(node.right, false, 1); // reset if we continue same direction
            }
        }
    }

}