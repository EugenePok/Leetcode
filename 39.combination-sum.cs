/*
 * @lc app=leetcode id=39 lang=csharp
 *
 * [39] Combination Sum
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        backtrack(candidates, new List<int>(), result, target, 0);
        return result;
    }

    public void backtrack(int[] candidates, List<int> initialNums, List<IList<int>> result, int remain, int startIndex)
    {
        if (remain < 0)
            return;
        else if (remain == 0)
            result.Add(new List<int>(initialNums));
        else
        {
            for (int i = startIndex; i < candidates.Count(); i++)
            {
                initialNums.Add(candidates[i]);
                backtrack(candidates, initialNums, result, remain - candidates[i], i);
                initialNums.RemoveAt(initialNums.Count() - 1);
            }
        }
    }
}
// @lc code=end

