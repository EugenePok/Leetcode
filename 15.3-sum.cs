/*
 * @lc app=leetcode id=15 lang=csharp
 *
 * [15] 3Sum
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> result = new List<IList<int>>();
        if (nums.Length < 3) return result;

        Array.Sort(nums);
        int start = 0, left, right;
        while (start < nums.Length - 2)
        {
            int target = -nums[start];
            left = start + 1;
            right = nums.Length - 1;
            while (left < right)
            {
                int sum = nums[left] + nums[right];
                if (sum < target)
                    left++;
                else if (sum > target)
                    right--;
                else
                {
                    int[] currentResult = new int[] { nums[start], nums[left], nums[right] };
                    result.Add(currentResult);

                    while (left < right && nums[left] == currentResult[1])
                        left++;
                    while (left < right && nums[right] == currentResult[2])
                        right--;
                }
            }
            int currentStartNumber = nums[start];
            while (start < nums.Length - 2 && nums[start] == currentStartNumber)
                start++;
        }
        return result;
    }
}
// @lc code=end

