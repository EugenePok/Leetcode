/*
 * @lc app=leetcode id=17 lang=javascript
 *
 * [17] Letter Combinations of a Phone Number
 */

// @lc code=start
/**
 * @param {string} digits
 * @return {string[]}
 */
var letterCombinations = function (digits) {
  if (digits.length == 0) return [];
  const map = ["abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"];
  const result = [];
  var subset = "";

  var helper = function (leftDigits, phoneChar, index) {
    if (index == digits.length) {
      result.push(subset);
    } else {
      for (var c of phoneChar) {
        subset += c;
        helper(leftDigits.slice(1), map[leftDigits[0] - "2"], index + 1);
        subset = subset.substring(0, subset.length - 1);
      }
    }
  };
  helper(digits.slice(1), map[digits[0] - "2"], 0);
  return result;
};
// @lc code=end
