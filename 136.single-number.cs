/*
 * @lc app=leetcode id=136 lang=csharp
 *
 * [136] Single Number
 */

// @lc code=start
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        int xor = 0;
        foreach (var i in nums)
            xor ^= i;
        return xor;
    }
}
// @lc code=end

