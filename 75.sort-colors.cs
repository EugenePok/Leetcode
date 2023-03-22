/*
 * @lc app=leetcode id=75 lang=csharp
 *
 * [75] Sort Colors
 */

// @lc code=start
public class Solution
{
    public void SortColors(int[] nums)
    {
        // twos : index after this was sorted
        // min(zeros, one) : index before this was sorted.
        int zeros = 0, ones = 0, twos = nums.Length - 1;
        while (ones <= twos)
        {
            if (nums[ones] == 0)
            {
                (nums[ones], nums[zeros]) = (nums[zeros], nums[ones]);
                zeros++; ones++;
            }
            else if (nums[ones] == 1)
                ones++;
            else
            {
                (nums[ones], nums[twos]) = (nums[twos], nums[ones]);
                twos--;
            }
        }
    }
}
// @lc code=end

