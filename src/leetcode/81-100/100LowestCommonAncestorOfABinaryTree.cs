internal static partial class Problem
{
    public static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null || root == p || root == q) return root;

        var left = LowestCommonAncestor(root.left, p, q);
        var right = LowestCommonAncestor(root.right, p, q);

        if (left != null && right != null) return root;

        if (left != null) return left;

        return right;
    }
}