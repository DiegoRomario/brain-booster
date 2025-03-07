using static Problem;

TreeNode root = new(3,
    new TreeNode(9),
    new TreeNode(20,
        new TreeNode(15),
        new TreeNode(7)
    )
);


Problem.MaxDepth(root);
