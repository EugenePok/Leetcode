using System.Collections;

TreeNode InvertTree(TreeNode root) {
    if(root == null)
        return root;
    if(root.left != null)
        InvertTree(root.left);
    if(root.right != null)
        InvertTree(root.right);
    var temp = root.left;
    root.left = root.right;
    root.right = temp;
    return root;
}

var root = InvertTree(new TreeNode(4, new TreeNode(2, null, new TreeNode(3)),
new TreeNode(7)));
Console.WriteLine();