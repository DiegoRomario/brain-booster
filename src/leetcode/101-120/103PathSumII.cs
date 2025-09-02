internal static partial class Problem
{
    public static IList<IList<int>> PathSum2(TreeNode root, int targetSum)
    {
        var result = new List<IList<int>>();
        var currentPath = new List<int>();
        DFS(root, targetSum, currentPath);
        return result;

        void DFS(TreeNode node, int remaining, List<int> path)
        {
            if (node == null) return;

            // include current node
            path.Add(node.val);

            // check if leaf and sum matches
            if (node.left == null && node.right == null && remaining == node.val)
            {
                result.Add(new List<int>(path)); // copy path
            }
            else
            {
                // recurse left and right
                DFS(node.left, remaining - node.val, path);
                DFS(node.right, remaining - node.val, path);
            }

            // backtrack
            path.RemoveAt(path.Count - 1);        
        }
    }
}