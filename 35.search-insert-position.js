/*
 * @lc app=leetcode id=35 lang=javascript
 *
 * [35] Search Insert Position
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number}
 */
var searchInsert = function (nums, target) {
  var low = 0;
  var high = nums.length - 1;
  while (low < high) {
    var mid = low + Math.floor((high - low) / 2);
    if (nums[mid] < target) low = mid + 1;
    else high = mid;
  }
  return nums[low] < target ? low + 1 : low;
};
// @lc code=end
