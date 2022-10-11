/*
 * @lc app=leetcode id=704 lang=csharp
 *
 * [704] Binary Search
 */

// @lc code=start
public class Solution {
    public int Search(int[] nums, int target) {
        int low = 0;
        int high = nums.Length - 1;
        while(low < high){
            int mid = Mid(low,high);
            if(target > nums[mid])
                low = mid + 1;
            else 
                high = mid;
        }
        return target == nums[low] ? low : -1;  
    }

    public int Mid(int low, int high) => low + (high-low) / 2;
}
// @lc code=end

