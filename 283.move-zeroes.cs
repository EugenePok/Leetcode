/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int snowBallSize = 0;
        for (int i = 0; i < nums.Count(); i++)
        {
            if (nums[i] != 0 && snowBallSize > 0)
            {
                int num = nums[i];
                nums[i] = 0;
                nums[i - snowBallSize] = num;
            }
            else
            {
                snowBallSize += nums[i] == 0 ? 1 : 0;
            }
        }
    }
}
// @lc code=end

