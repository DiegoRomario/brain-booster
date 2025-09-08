internal static partial class Problem
{
    public static int MaxLevelSum(TreeNode root)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var maximumSum = int.MinValue;
        var maximumSumLevel = int.MinValue;
        var currentLevel = 0;

        while (queue.Count > 0)
        {
            var count = queue.Count;
            var currentSum = 0;
            currentLevel++;

            for (var i = 0; i < count; i++)
            {
                var target = queue.Dequeue();

                if (target.left is not null) queue.Enqueue(target.left);
                if (target.right is not null) queue.Enqueue(target.right);

                currentSum += target.val;
            }

            if (currentSum <= maximumSum) continue;

            maximumSum = currentSum;
            maximumSumLevel = currentLevel;
        }

        return maximumSumLevel;
    }

    public static int MaxLevelSumRecursive(TreeNode root)
    {
        List<int> sums = [];
        SumLevels(root, 1, sums);
        int max = int.MinValue;
        int maxIdx = 0;
        for (int i = 0; i < sums.Count; i++)
        {
            if (sums[i] > max)
            {
                max = sums[i];
                maxIdx = i;
            }
        }

        return maxIdx + 1;

        static void SumLevels(TreeNode root, int level, List<int> sums)
        {
            if (level > sums.Count)
                sums.Add(0);

            sums[level - 1] += root.val;

            if (root.left != null)
                SumLevels(root.left, level + 1, sums);
            if (root.right != null)
                SumLevels(root.right, level + 1, sums);
        }
    }
}