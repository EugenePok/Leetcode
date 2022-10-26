/*
 * @lc app=leetcode id=110 lang=csharp
 *
 * [110] Balanced Binary Tree
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int dfsHeight(TreeNode root){
        if(root == null) return 0;

        int leftHeight = dfsHeight(root.left);
        int rightHeight = dfsHeight(root.right);
        if(Math.Abs(leftHeight - rightHeight) > 1 || leftHeight == -1 || rightHeight == -1)
            return -1;
        return Math.Max(leftHeight,rightHeight) + 1;
    }

    public bool IsBalanced(TreeNode root) {
        if(root == null)
            return true;
        return dfsHeight(root) != -1;
    }
}
// @lc code=end

