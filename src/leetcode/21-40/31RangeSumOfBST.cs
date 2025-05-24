internal static partial class Problem
{
    public static int RangeSumBST(TreeNode root, int low, int high)
    {
        int total = Recursion(root, low, high, 0);
        return total;
    }

    public static int Recursion(TreeNode root, int low, int high, int total)
    {
        if (root is null) return total;

        if (root.val >= low && root.val <= high)
        {
            total += root.val;
        }

        total = root.val >= low ? Recursion(root.left, low, high, total) : total;
        total = root.val <= high ? Recursion(root.right, low, high, total) : total;

        return total;
    }
}

