/*
 * @lc app=leetcode id=78 lang=javascript
 *
 * [78] Subsets
 */

// @lc code=start
/**
 * @param {number[]} nums
 * @return {number[][]}
 */

var subsets = function (nums) {
  const res = [];
  const subset = [];

  const createSubset = function (i) {
    if (i === nums.length) {
      res.push([...subset]);
    } else {
      subset.push(nums[i]);
      createSubset(i + 1);

      subset.pop();
      createSubset(i + 1);
    }
  };

  createSubset(0);
  return res;
};
// @lc code=end
