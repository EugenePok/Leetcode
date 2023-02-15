/*
 * @lc app=leetcode id=46 lang=csharp
 *
 * [46] Permutations
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> Permute(int[] nums)
    {
        List<IList<int>> result = new List<IList<int>>();
        backtrack(nums, result, new List<int>());
        return result;
    }

    void backtrack(int[] nums, List<IList<int>> result, List<int> initialState)
    {
        if (initialState.Count == nums.Length)
            result.Add(new List<int>(initialState));
        else
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (initialState.Contains(nums[i])) continue;
                initialState.Add(nums[i]);
                backtrack(nums, result, initialState);
                initialState.RemoveAt(initialState.Count() - 1);
            }
        }
    }
}
// @lc code=end

