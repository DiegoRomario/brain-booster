internal static partial class Problem
{
    public static bool EvaluateTree(TreeNode root)
    {
        if (root.left is null) return root.val == 1;

        if (root.val == 2)
            return (EvaluateTree(root.left) || EvaluateTree(root.right));
        else
            return (EvaluateTree(root.left) && EvaluateTree(root.right));
    }
}