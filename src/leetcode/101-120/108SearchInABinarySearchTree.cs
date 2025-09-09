internal static partial class Problem
{
    public static TreeNode SearchBST(TreeNode root, int val)
    {

        if (root == null || root.val == val)
            return root;

        if (val < root.val)
            return SearchBST(root.left, val);
        else
            return SearchBST(root.right, val);
    }
}

