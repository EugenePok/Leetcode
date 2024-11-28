/*
 * @lc app=leetcode id=62 lang=javascript
 *
 * [62] Unique Paths
 */

// @lc code=start
/**
 * @param {number} m
 * @param {number} n
 * @return {number}
 */
var uniquePaths = function (m, n) {
  let aboveRow = Array(n).fill(1);
  for (let row = 1; row < m; row++) {
    let currentRow = Array(n);
    currentRow[0] = 1;
    for (let col = 1; col < n; col++) {
      currentRow[col] = currentRow[col - 1] + aboveRow[col];
    }
    aboveRow = currentRow;
  }
  return aboveRow[n - 1];
};
// @lc code=end
