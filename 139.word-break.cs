/*
 * @lc app=leetcode id=139 lang=csharp
 *
 * [139] Word Break
 */

// @lc code=start
public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        HashSet<string> set = new HashSet<string>(wordDict);
        bool[] dp = new bool[s.Length + 1];
        dp[0] = true;

        for (int i = 0; i < s.Length && !dp[s.Length]; i++)
        {
            if (!dp[i])
                continue;
            for (int j = i + 1; j <= s.Length; j++)
                if (set.Contains(s.Substring(i, j - i)))
                    dp[j] = true;
        }
        return dp[s.Length];
    }
}
// @lc code=end

