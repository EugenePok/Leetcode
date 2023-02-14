/*
 * @lc app=leetcode id=90 lang=csharp
 *
 * [90] Subsets II
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        Array.Sort(nums);
        IList<IList<int>> result = new List<IList<int>>();
        backtrack(result, new List<int>(), 0, nums);
        return result;
    }

    public void backtrack(IList<IList<int>> initialList, List<int> tempList, int start, int[] initialNums)
    {
        initialList.Add(new List<int>(tempList));
        for (int i = start; i < initialNums.Length; i++)
        {
            if (i > start && initialNums[i] == initialNums[i - 1])
                continue;
            tempList.Add(initialNums[i]);
            backtrack(initialList, tempList, i + 1, initialNums);
            tempList.RemoveAt(tempList.Count() - 1);
        }
    }
}
// @lc code=end

