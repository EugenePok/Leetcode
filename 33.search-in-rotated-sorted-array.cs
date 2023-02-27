/*
 * @lc app=leetcode id=33 lang=csharp
 *
 * [33] Search in Rotated Sorted Array
 */

// @lc code=start
public class Solution
{
    public int Search(int[] nums, int target)
    {
        int low = 0;
        int high = nums.Count();

        while (low < high)
        {
            int mid = low + ((high - low) / 2);
            //is mid and target on same side that excluded pivot already?
            int num = nums[0] > nums[mid] == nums[0] > target
                ? nums[mid] : (nums[0] > target) ? int.MinValue : int.MaxValue;

            if (num > target)
                high = mid;
            else if (num < target)
                low = mid + 1;
            else
                return mid;
        }
        return -1;
    }
}
// @lc code=end

