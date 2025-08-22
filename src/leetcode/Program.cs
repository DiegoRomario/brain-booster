using static Problem;


TreeNode root = new(3,
    new TreeNode(2,
        new TreeNode(1),
        new TreeNode(2,
            new TreeNode(1),
            new TreeNode(0)
        )
    ),
    new TreeNode(2,
        new TreeNode(1),
        new TreeNode(0)
    )
);


EvaluateTree(root);
Console.ReadKey();