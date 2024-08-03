/*
 * @lc app=leetcode id=416 lang=csharp
 *
 * [416] Partition Equal Subset Sum
 */

// @lc code=start
public class Solution
{
    public bool CanPartition(int[] nums)
    {
        int expectedSum = 0;
        foreach (int num in nums)
            expectedSum += num;

        if (IsOddInteger(expectedSum))
            return false;
        expectedSum /= 2;

        bool[] dp = new bool[expectedSum + 1];
        dp[0] = true;

        foreach (int currentNumSelection in nums)
            for (int i = expectedSum; i > 0 && i - currentNumSelection >= 0 && !dp[expectedSum]; i--)
                dp[i] = dp[i] || dp[i - currentNumSelection];

        return dp[expectedSum];

    }

    public bool IsOddInteger(int value) => (value & 1) != 0;
}
// @lc code=end

