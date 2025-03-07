internal static partial class Problem
{
    public static int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        int leftDepth = MaxDepth(root.left);
        int rightDepth = MaxDepth(root.right);

        return 1 + (leftDepth > rightDepth ? leftDepth : rightDepth);

    }
}
