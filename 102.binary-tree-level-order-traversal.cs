/*
 * @lc app=leetcode id=102 lang=csharp
 *
 * [102] Binary Tree Level Order Traversal
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
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();
        dfs(root, result, 0);
        return result;
    }

    void dfs(TreeNode root, IList<IList<int>> result, int level)
    {
        if (root == null) return;
        if (result.Count() - 1 < level)
            result.Add(new List<int>());
        result[level].Add(root.val);
        dfs(root.left, result, level + 1);
        dfs(root.right, result, level + 1);
    }
}
// @lc code=end

