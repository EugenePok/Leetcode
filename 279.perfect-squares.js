/*
 * @lc app=leetcode id=279 lang=javascript
 *
 * [279] Perfect Squares
 */

// @lc code=start
/**
 * @param {number} n
 * @return {number}
 */
var numSquares = function (n) {
  let memo = Array(n + 1).fill(10000);
  memo[0] = 0;
  for (let i = 1; i <= n; i++) {
    for (let j = 1; j * j <= i; j++) {
      memo[i] = Math.min(memo[i], memo[i - j * j] + 1);
    }
  }
  return memo[n];
};
// @lc code=end
