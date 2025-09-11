internal static partial class Problem
{
    public static TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;

        if (key < root.val)
        {
            root.left = DeleteNode(root.left, key);
        }
        else if (key > root.val)
        {
            root.right = DeleteNode(root.right, key);
        }
        else // found the node to delete
        {
            if (root.left == null) return root.right;
            if (root.right == null) return root.left;

            // Find inorder predecessor (max in left subtree)
            TreeNode pred = root.left;
            while (pred.right != null)
                pred = pred.right;

            root.val = pred.val; // replace value
            root.left = DeleteNode(root.left, pred.val); // delete duplicate
        }

        return root;
    }
}

