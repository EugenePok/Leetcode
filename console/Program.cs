using System.Collections;

int dfsHeight (TreeNode root) {
    if (root == null) return 0;
    
    int leftHeight = dfsHeight (root.left);
    if (leftHeight == -1) return -1;
    int rightHeight = dfsHeight (root.right);
    if (rightHeight == -1) return -1;
    
    if (Math.Abs(leftHeight - rightHeight) > 1)  
        return -1;
    return Math.Max(leftHeight, rightHeight) + 1;
}
bool isBalanced(TreeNode root) {
    return dfsHeight (root) != -1;
}

Console.WriteLine(isBalanced(new TreeNode(1,new TreeNode(2, 
new TreeNode(3), new TreeNode(3)))));
