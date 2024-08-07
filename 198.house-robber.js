/*
 * @lc app=leetcode id=198 lang=javascript
 *
 * [198] House Robber
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @return {number}
 */
var rob = function (nums) {
  let memo = Array(nums.length);
  memo[nums.length - 1] = nums[nums.length - 1];
  return memoRob(nums, 0, memo);
};

var memoRob = function (nums, i, memo) {
  if (i >= nums.length) return 0;
  if (memo[i] != null) return memo[i];
  memo[i] = Math.max(
    nums[i] + memoRob(nums, i + 2, memo),
    memoRob(nums, i + 1, memo)
  );
  return memo[i];
};
// @lc code=end
