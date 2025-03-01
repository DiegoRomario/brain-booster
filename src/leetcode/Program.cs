using static Problem;

TreeNode root = new TreeNode(1,
    new TreeNode(2,
        new TreeNode(4),
        new TreeNode(5,
            new TreeNode(6),
            new TreeNode(7)
        )
    ),
    new TreeNode(3,
        null,
        new TreeNode(8,
            new TreeNode(9),
            null
        )
    )
);


Problem.InorderTraversal(root);
Problem.InorderTraversalRecursion(root);
