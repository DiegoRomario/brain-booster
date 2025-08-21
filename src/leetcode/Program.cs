using static Problem;


TreeNode root = new(3,
    new TreeNode(5,
        new TreeNode(6),
        new TreeNode(2,
            new TreeNode(7),
            new TreeNode(4)
        )
    ),
    new TreeNode(1,
        new TreeNode(9),
        new TreeNode(8)
    )
);


LeafSimilar(root, root);
Console.ReadKey();