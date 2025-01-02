/*
 * @lc app=leetcode id=1 lang=javascript
 *
 * [1] Two Sum
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
  let dict = {};
  for (var i = 0; i < nums.length; i++) {
    if (dict.hasOwnProperty(nums[i])) return [i, dict[nums[i]]];
    else dict[target - nums[i]] = i;
  }
};
// @lc code=end
