/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();
        foreach (var i in nums)
        {
            if (!hash.Add(i))
                return true;
        }
        return false;
    }
}
// @lc code=end

