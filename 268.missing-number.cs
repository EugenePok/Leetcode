/*
 * @lc app=leetcode id=268 lang=csharp
 *
 * [268] Missing Number
 */

// @lc code=start
public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int result = nums.Length;
        for (int i = 0; i < nums.Length; i++)
        {
            result = result ^ i ^ nums[i];
        }
        return result;
    }
}
// @lc code=end

