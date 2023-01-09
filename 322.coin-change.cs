/*
 * @lc app=leetcode id=322 lang=csharp
 *
 * [322] Coin Change
 */

// @lc code=start
public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount < 1) return 0;
        int[] result = new int[amount + 1];
        Array.Sort(coins);
        for (int i = 1; i <= amount; i++)
        {
            result[i] = int.MaxValue;
            foreach (var coin in coins)
            {
                if (coin > i) break;
                if (result[i - coin] != int.MaxValue)
                    result[i] = Math.Min(result[i], 1 + result[i - coin]);
            }
        }
        return result[amount] == int.MaxValue ? -1 : result[amount];
    }
}
// @lc code=end

