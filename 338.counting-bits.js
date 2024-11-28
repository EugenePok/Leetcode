/*
 * @lc app=leetcode id=338 lang=javascript
 *
 * [338] Counting Bits
 */

// @lc code=start
/**
 * @param {number} n
 * @return {number[]}
 */
var countBits = function (n) {
  let memo = Array(n + 1);
  memo[0] = 0;
  for (let i = 0; i <= n; i++) {
    memo[i] = memo[i >> 1] + (i % 2);
  }
  return memo;
};
// @lc code=end
