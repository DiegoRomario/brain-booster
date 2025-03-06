internal static partial class Problem
{
    public static bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;
        Queue<TreeNode> queue = [];
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);

        while (queue.Count > 0)
        {
            TreeNode left = queue.Dequeue();
            TreeNode right = queue.Dequeue();

            if (left == null && right == null) continue;
            if (left == null || right == null || left.val != right.val) return false;

            queue.Enqueue(left.left);
            queue.Enqueue(right.right);
            queue.Enqueue(left.right);
            queue.Enqueue(right.left);
        }
        return true;
    }

    public static bool IsSymmetricRecursion(TreeNode root)
    {
        if (root == null) return true;
        return IsMirror(root.left, root.right);

        static bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return (left.val == right.val)
                && IsMirror(left.left, right.right)
                && IsMirror(left.right, right.left);
        }
    }
}
