internal static partial class Problem
{
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root is not null)
        {
            var temp = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(temp);
        }
        return root;
    }
}


