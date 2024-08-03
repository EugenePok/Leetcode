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
  let min = prices[0];
  let profit = 0;
  for (let i = 1; i < prices.length; i++) {
    min = Math.min(prices[i], min);
    profit = Math.max(profit, prices[i] - min);
  }
  return profit;
};
// @lc code=end
