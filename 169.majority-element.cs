/*
 * @lc app=leetcode id=169 lang=csharp
 *
 * [169] Majority Element
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        int currentMajority = nums[0], count = 1;
        for(int i = 1 ; i< nums.Length; i++){
            if(count == 0)
            {
                count++;
                currentMajority = nums[i];
            }
            else if(nums[i] == currentMajority)
                count++;
            else
                count--;
        }
        return currentMajority;
    }
}
// @lc code=end

