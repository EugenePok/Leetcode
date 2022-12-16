/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Count() == 0)
            return "";
        if (strs.Count() == 1)
            return strs.First();
        Array.Sort(strs);
        var first = strs.First();
        var last = strs.Last();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < first.Length; i++)
        {
            if (first[i] == last[i])
                sb.Append(first[i]);
            else
                i = first.Length;
        }
        return sb.ToString();
    }
}
// @lc code=end

