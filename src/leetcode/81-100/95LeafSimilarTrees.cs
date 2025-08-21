internal static partial class Problem
{
    public static bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        List<int> list1 = [];
        List<int> list2 = [];

        CheckLeaf(root1, list1);
        CheckLeaf(root2, list2);

        static void CheckLeaf(TreeNode root, List<int> list)
        {
            if (root is null) return;

            if (root.left is null && root.right is null)
            {
                list.Add(root.val);
                return;
            }

            CheckLeaf(root.left, list);
            CheckLeaf(root.right, list);
        }

        if (list1.Count != list2.Count)
            return false;

        for (var index = 0; index < list1.Count; index++)
        {
            if (list1[index] != list2[index]) return false;
        }

        return true;

        // return  list1.SequenceEqual(list2);
    }
}