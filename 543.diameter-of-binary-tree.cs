/*
 * @lc app=leetcode id=543 lang=csharp
 *
 * [543] Diameter of Binary Tree
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
public class Solution
{
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root)
    {
        maxDepth(root);
        return max;
    }

    public int maxDepth(TreeNode root)
    {
        if (root == null) return 0;

        int left = maxDepth(root.left);
        int right = maxDepth(root.right);

        max = Math.Max(max, left + right);
        return Math.Max(left, right) + 1;
    }
}
// @lc code=end

