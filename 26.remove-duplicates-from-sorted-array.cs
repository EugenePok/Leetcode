/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length == 1 || nums[0] == 100) return 1;

        int completedIndex = 0;
        int currentNum = nums[completedIndex];

        for(int i = 0 ; i < nums.Length; i++){
            if(currentNum == nums[i]) continue;
            nums[++completedIndex] = nums[i];
            currentNum = nums[i];
        }

        return completedIndex + 1;
    }
}
// @lc code=end

