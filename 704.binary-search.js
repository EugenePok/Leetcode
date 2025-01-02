/*
 * @lc app=leetcode id=704 lang=javascript
 *
 * [704] Binary Search
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var search = function (nums, target) {
  var min = 0;
  var max = nums.length - 1;
  while (min < max) {
    var mid = Math.floor(min + (max - min) / 2);
    if (nums[mid] < target) min = mid + 1;
    else max = mid;
  }
  return nums[min] == target ? min : -1;
};
console.log(search([2, 5], 5));
// @lc code=end
