/*
 * @lc app=leetcode id=343 lang=javascript
 *
 * [343] Integer Break
 */

// @lc code=start
/**
 * @param {number} n
 * @return {number}
 */
var integerBreak = function (n) {
  if (n == 2) return 1;
  if (n == 3) return 2;

  var numberOf3 = Math.floor(n / 3);
  var remainder = n % 3;

  if (remainder == 0) return 3 ** numberOf3;
  if (remainder == 1) return 3 ** (numberOf3 - 1) * 4;
  return 3 ** numberOf3 * 2;
};
// @lc code=end
