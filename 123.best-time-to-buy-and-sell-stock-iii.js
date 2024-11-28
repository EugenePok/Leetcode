/*
 * @lc app=leetcode id=123 lang=javascript
 *
 * [123] Best Time to Buy and Sell Stock III
 */

// @lc code=start
/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  di20 = 0;
  di21 = -Infinity;
  di10 = 0;
  di11 = -Infinity;
  for (let i = 0; i < prices.length; i++) {
    di10 = Math.max(di10, di11 + prices[i]);
    di11 = Math.max(di11, -prices[i]);
    di21 = Math.max(di21, di10 - prices[i]);
    di20 = Math.max(di20, di21 + prices[i]);
  }
  return di20;
};
// @lc code=end
