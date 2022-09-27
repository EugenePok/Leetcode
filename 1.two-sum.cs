/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //Create a hash table with key as target searching and value as index matched
        Hashtable dic = new Hashtable();

        for(int i = 0; i < nums.Length; i++){
            if(dic.ContainsKey(nums[i]))
                return new int[] { (int)dic[nums[i]], i };
            else
                dic[target - nums[i]] = i;
        }

        return new int[] { };
    }
}
// @lc code=end

