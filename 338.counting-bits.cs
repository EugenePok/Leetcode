/*
 * @lc app=leetcode id=338 lang=csharp
 *
 * [338] Counting Bits
 */

// @lc code=start
public class Solution
{
    public int[] CountBits(int n)
    {
        if (n == 0) return new int[] { 0 };
        int[] memo = new int[n + 1];
        memo[0] = 0;
        memo[1] = 1;
        for (int i = 0; i <= n; i++)
            memo[i] = memo[i / 2] + (i % 2);
        return memo;
    }
}
// @lc code=end

