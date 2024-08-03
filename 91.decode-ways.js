/*
 * @lc app=leetcode id=91 lang=javascript
 *
 * [91] Decode Ways
 */

// @lc code=start
/**
 * @param {string} s
 * @return {number}
 */
var numDecodings = function (s) {
  return decode(s);
};

var decode = function (s, memo = {}) {
  if (s === "") return 1;
  if (s in memo) return memo[s];
  let t1 = s.substring(0, 1);
  if (t1 === "0") return 0;
  let total = 0;
  if (parseInt(t1) <= 26) total += decode(s.slice(1), memo);
  if (s.length > 1 && parseInt(s.substring(0, 2)) <= 26) {
    total += decode(s.slice(2), memo);
  }
  memo[s] = total;
  return total;
};

// console.log(numDecodings("12")); //2
// console.log(numDecodings("226")); //3
// console.log(numDecodings("06")); //0
// console.log(numDecodings("2222")); //5
// console.log(numDecodings("2626")); //4
//console.log(numDecodings("111111111111111111111111111111111111111111111")); //1836311903
// @lc code=end
