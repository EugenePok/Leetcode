/*
 * @lc app=leetcode id=101 lang=csharp
 *
 * [101] Symmetric Tree
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
    public bool IsSymmetric(TreeNode root)
    {
        return isSameVal(root.left, root.right);
    }

    bool isSameVal(TreeNode left, TreeNode right)
    {
        if (left == null || right == null)
            return left == right;
        if (left.val != right.val)
            return false;
        return isSameVal(left.left, right.right) && isSameVal(left.right, right.left);
    }
}
// @lc code=end

