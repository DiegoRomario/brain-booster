internal static partial class Problem
{
    public static int PathSum3(TreeNode root, int targetSum)
    {
        int paths;       
        paths = 0;
        Dictionary<long, int>  pathSums = new()
        {
            [0] = 1 // Base case
        };

        DFS(root, 0);
        return paths;

        void DFS(TreeNode node, long currSum)
        {
            if (node == null) return;

            currSum += node.val;

            if (pathSums.ContainsKey(currSum - targetSum))
            {
                paths += pathSums[currSum - targetSum];
            }

            if (!pathSums.ContainsKey(currSum))
            {
                pathSums[currSum] = 0;
            }

            pathSums[currSum]++;

            DFS(node.left, currSum);
            DFS(node.right, currSum);

            // Backtrack
            pathSums[currSum]--;
        }
    }
}