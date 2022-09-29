/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if(nums.Length == 0) return 0;
        if(val > 50) return nums.Length;

        int currentIndex = 0;
        for(int i = 0 ; i < nums.Length ; i++){
            if(nums[i] == val) continue;
            nums[currentIndex++] = nums[i];
        }
        return currentIndex;
    }
}
// @lc code=end

