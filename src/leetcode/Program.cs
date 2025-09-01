using static Problem;

TreeNode left = new(3);
TreeNode right = new(3);
TreeNode root = new(3, left, right);

PathSum(root, 1);
Console.ReadKey();