/*
 * @lc app=leetcode id=122 lang=javascript
 *
 * [122] Best Time to Buy and Sell Stock II
 */

// @lc code=start
/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  var dpi0 = 0;
  var dpi1 = -Infinity;

  for (let i = 0; i < prices.length; i++) {
    dpi0 = Math.max(dpi0, dpi1 + prices[i]);
    dpi1 = Math.max(dpi1, dpi0 - prices[i]);
  }

  return dpi0;
};
// @lc code=end
