/*
 * @lc app=leetcode id=78 lang=csharp
 *
 * [78] Subsets
 */

// @lc code=start
public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        IList<IList<int>> result = getSubSet(new List<int>(), 0, nums);
        result.Add(new int[] { });
        return result;
    }

    IList<IList<int>> getSubSet(List<int> initialState, int startIndex, int[] originalArray)
    {
        List<IList<int>> result = new List<IList<int>>();
        for (int i = startIndex; i < originalArray.Length; i++)
        {
            List<int> temp = new List<int>(initialState);
            temp.Add(originalArray[i]);
            if (i < originalArray.Length - 1)
                result.AddRange(getSubSet(temp, i + 1, originalArray));
            result.Add(temp);
        }
        return result;
    }
}
// @lc code=end

