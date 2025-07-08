internal static partial class Problem
{
    private static readonly TreeNode SingleNode = new();
    private static readonly TreeNode SimpleNode = new(0, SingleNode, SingleNode);

    public static IList<TreeNode> AllPossibleFBT(int n)
    {
        if (n % 2 == 0) return [];

        var cachedTrees = new List<TreeNode>[n + 3];
        cachedTrees[1] = [SingleNode];
        cachedTrees[3] = [SimpleNode];

        for (var i = 5; i <= n; i += 2)
        {
            var trees = new List<TreeNode>();
            for (var j = 1; j < i; j += 2)
            {
                foreach (var lt in cachedTrees[j])
                    foreach (var rt in cachedTrees[i - j - 1])
                        trees.Add(new (0, lt, rt));
            }
            cachedTrees[i] = trees;
        }

        return [.. cachedTrees[n].Select(Copy)];

        static TreeNode Copy(TreeNode node) => node is null ? null : new(0, Copy(node.left), Copy(node.right));
    }
}
