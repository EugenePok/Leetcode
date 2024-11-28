/*
 * @lc app=leetcode id=357 lang=javascript
 *
 * [357] Count Numbers with Unique Digits
 */

// @lc code=start
/**
 * @param {number} n
 * @return {number}
 */
var countNumbersWithUniqueDigits = function (n) {
  if (n === 0) return 1;
  let result = 10;
  let uniqueDigit = 9;
  let availableNumber = 9;
  while (n-- > 1 && availableNumber > 0) {
    uniqueDigit *= availableNumber--;
    result += uniqueDigit;
  }
  return result;
};
// @lc code=end
