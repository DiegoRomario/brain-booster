using static Problem;

TreeNode root = new(1,
    new(2,
        new(3),
        new(4)
    ),
    new(2,
        new(4),
        new(3)
    )
);


Problem.IsSymmetric(root);
