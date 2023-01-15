/*
 * @lc app=leetcode id=977 lang=csharp
 *
 * [977] Squares of a Sorted Array
 */

// @lc code=start
public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        int i = 0; int j = nums.Length - 1;
        int[] results = new int[nums.Length];
        for (int k = nums.Length - 1; k >= 0; k--)
            results[k] = Math.Abs(nums[i]) > Math.Abs(nums[j])
            ? nums[i] * nums[i++]
            : nums[j] * nums[j--];
        return results;
    }
}
// @lc code=end

