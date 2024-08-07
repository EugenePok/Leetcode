/*
 * @lc app=leetcode id=309 lang=javascript
 *
 * [309] Best Time to Buy and Sell Stock with Cooldown
 */

// @lc code=start
/**
 * @param {number[]} prices
 * @return {number}
 */
var maxProfit = function (prices) {
  let sold = 0,
    hold = Number.MIN_SAFE_INTEGER,
    rest = 0;
  for (let i = 0; i < prices.length; i++) {
    let prvSold = sold;
    sold = hold + prices[i];
    hold = Math.max(hold, rest - prices[i]);
    rest = Math.max(rest, prvSold);
  }
  return Math.max(sold, rest);
};

maxProfit([1, 2, 3, 0, 2]);
// @lc code=end
