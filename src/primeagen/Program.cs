// Example binary tree:
//        1
//       / \
//      2   3
//     / \   \
//    4   5   6

using static primeagen.Problem;

var tree = new BinaryNode<int>(
    1,
    new BinaryNode<int>(
        2,
        new BinaryNode<int>(4),
        new BinaryNode<int>(5)
    ),
    new BinaryNode<int>(
        3,
        null,
        new BinaryNode<int>(6)
    )
);

Console.WriteLine("Pre-Order Recursive:   " + string.Join(", ", PreOrderRecursive(tree)));
Console.WriteLine("Pre-Order Iterative:   " + string.Join(", ", PreOrderIterative(tree)));

Console.WriteLine("In-Order Recursive:    " + string.Join(", ", InOrderRecursive(tree)));
Console.WriteLine("In-Order Iterative:    " + string.Join(", ", InOrderIterative(tree)));

Console.WriteLine("Post-Order Recursive:  " + string.Join(", ", PostOrderRecursive(tree)));
Console.WriteLine("Post-Order Iterative:  " + string.Join(", ", PostOrderIterative(tree)));

Console.WriteLine("Search 5:  " + string.Join(", ", DFS(tree, 3)));
Console.WriteLine("Search 7:  " + string.Join(", ", DFS(tree, 7)));