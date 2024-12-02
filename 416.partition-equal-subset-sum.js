/*
 * @lc app=leetcode id=416 lang=javascript
 *
 * [416] Partition Equal Subset Sum
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @return {boolean}
 */
var canPartition = function (nums) {
  var sum = nums.reduce((a, b) => a + b);
  if (sum % 2 != 0) return false;
  var dp = new Array(sum / 2 + 1).fill(false);
  dp[0] = true; //base case

  for (let i = 1; i < nums.length; i++) {
    for (let j = sum / 2; j >= 0; j--) {
      if (j - nums[i - 1] >= 0) {
        dp[j] = dp[j - nums[i - 1]] || dp[j];
        if (j == sum / 2 && dp[j]) {
          return true;
        }
      }
    }
  }
  return false;
};
// @lc code=end
