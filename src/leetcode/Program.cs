
using static Problem;

// Level 3
TreeNode leftLeft = new TreeNode(4);
TreeNode leftRight = new TreeNode(5);
TreeNode rightLeft = new TreeNode(6);
TreeNode rightRight = new TreeNode(7);

// Level 2
TreeNode left = new TreeNode(2, leftLeft, leftRight);
TreeNode right = new TreeNode(3, rightLeft, rightRight);

// Level 1 (Root)
TreeNode root = new TreeNode(1, left, right);
var result = InvertTree(root);
Console.ReadKey();


//TreeNode node3 = new TreeNode(3);
//TreeNode node2 = new TreeNode(2, null, node3);
//TreeNode node1 = new TreeNode(1, null, node2);
//TreeNode root = new TreeNode(4, null, node1);