/*
 * @lc app=leetcode id=121 lang=javascript
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  if (prices.length < 2) return 0;
  let d0 = 0;
  let d1 = -prices[0];
  for (var i = 1; i < prices.length; i++) {
    d0 = Math.max(d1 + prices[i], d0);
    d1 = Math.max(-prices[i], d1);
  }
  return d0;
};
// @lc code=end
