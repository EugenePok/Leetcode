/*
 * @lc app=leetcode id=242 lang=javascript
 *
 * [242] Valid Anagram
 */

// @lc code=start
/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
var isAnagram = function (s, t) {
  if (s.length != t.length) {
    return false;
  }
  var array = [];
  for (var c in s) {
    var i = s.charCodeAt(c) - 97;
    array[i] = (array[i] || 0) + 1;
  }
  for (var c in t) {
    var i = t.charCodeAt(c) - 97;
    if (!array[i]) return false;
    array[i]--;
  }
  return true;
};
// @lc code=end
