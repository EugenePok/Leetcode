/*
 * @lc app=leetcode id=53 lang=csharp
 *
 * [53] Maximum Subarray
 */

// @lc code=start
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        return MaxSubArray(nums, 0, nums.Count() - 1);
    }

    public int MaxSubArray(int[] nums, int L, int R)
    {
        if (L > R) return int.MinValue;
        int mid = (L + R) / 2, leftSum = 0, rightSum = 0;
        for (int i = mid - 1, curSum = 0; i >= L; i--)
        {
            curSum += nums[i];
            leftSum = Math.Max(curSum, leftSum);
        }
        for (int i = mid + 1, curSum = 0; i <= R; i++)
        {
            curSum += nums[i];
            rightSum = Math.Max(curSum, rightSum);
        }
        return new int[] { leftSum + rightSum + nums[mid], MaxSubArray(nums, L, mid - 1), MaxSubArray(nums, mid + 1, R) }.Max();
    }
}
// @lc code=end

