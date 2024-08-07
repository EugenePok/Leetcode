/*
 * @lc app=leetcode id=322 lang=javascript
 *
 * [322] Coin Change
 */

// @lc code=start
/**
 * @param {number[]} coins
 * @param {number} amount
 * @return {number}
 */
var coinChange = function (coins, amount) {
  if (amount === 0) return 0;
  let solution = Array(amount + 1).fill(Number.MAX_SAFE_INTEGER);
  solution[0] = 0;
  coins.sort(function (a, b) {
    return a - b;
  });
  for (let i = 1; i <= amount; i++) {
    for (let j = 0; j < coins.length; j++) {
      if (coins[j] > i) {
        j = coins.length;
        break;
      }
      if (solution[i - coins[j]] != Number.MAX_SAFE_INTEGER)
        solution[i] = Math.min(solution[i], solution[i - coins[j]] + 1);
    }
  }
  return solution[amount] == Number.MAX_SAFE_INTEGER ? -1 : solution[amount];
};
// @lc code=end
