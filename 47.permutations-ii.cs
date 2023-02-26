/*
 * @lc app=leetcode id=47 lang=csharp
 *
 * [47] Permutations II
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> PermuteUnique(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        backtrack(nums, new List<int>(), result, new bool[nums.Count()]);
        return result;
    }

    public void backtrack(int[] nums, List<int> initialNums, List<IList<int>> result, bool[] used)
    {
        if (initialNums.Count == nums.Count())
            result.Add(new List<int>(initialNums));
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (used[i] || i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) 
                    continue;
                used[i] = true;
                initialNums.Add(nums[i]);
                backtrack(nums, initialNums, result, used);
                used[i] = false;
                initialNums.RemoveAt(initialNums.Count() - 1);
            }
        }
    }
}
// @lc code=end

