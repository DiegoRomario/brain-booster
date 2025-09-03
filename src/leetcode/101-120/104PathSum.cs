internal static partial class Problem
{
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        bool has = false;
        DFS(root, 0);
        return has;

        void DFS(TreeNode node, int sum)
        {
            if (node is null) return;

            sum += node.val;

            if (sum == targetSum && node.left is null && node.right is null)
            {
                has = true;
                return;
            }

            DFS(node.left, sum);
            DFS(node.right, sum);
        }

    }

    public static bool HasPathSum2(TreeNode root, int targetSum)
    {
        int sum = 0;
        bool has = false;
        DFS(root);
        return has;

        void DFS(TreeNode node)
        {
            if (node is null) return;

            sum += node.val;

            if (sum == targetSum && node.left is null && node.right is null)
            {
                has = true;
                return;
            }

            DFS(node.left);
            DFS(node.right);

            sum -= node.val;
        }
    }

    public static bool HasPathSum3(TreeNode root, int targetSum)
    {
        return DFS(root, targetSum, 0);

        static bool DFS(TreeNode root, int targetSum, int sum)
        {
            if (root == null) return false;
            sum += root.val;
            if (root.left == null && root.right == null)
            {
                return (sum == targetSum);
            }

            bool l = DFS(root.left, targetSum, sum);
            bool r = DFS(root.right, targetSum, sum);

            return l || r;
        }
    }
}