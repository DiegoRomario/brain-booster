
using static Problem;

TreeNode root = new(10,
       new TreeNode(5,
           new TreeNode(3),
           new TreeNode(7)
       ),
       new TreeNode(15,
           null,
           new TreeNode(18)
       )
   );
var result = RangeSumBST(root,7,15);
Console.ReadKey();
