/*
 * @lc app=leetcode id=20 lang=javascript
 *
 * [20] Valid Parentheses
 */

// @lc code=start
/**
 * @param {string} s
 * @return {boolean}
 */
var isValid = function (s) {
  var stack = [];
  for (var p of s) {
    if (p == "(" || p == "[" || p == "{") stack.push(p);
    else {
      var last = stack.pop();
      if (last == "(" && p == ")") continue;
      else if (last == "[" && p == "]") continue;
      else if (last == "{" && p == "}") continue;
      return false;
    }
  }
  return stack.length == 0;
};
// @lc code=end
