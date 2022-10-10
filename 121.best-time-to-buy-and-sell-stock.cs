/*
 * @lc app=leetcode id=121 lang=csharp
 *
 * [121] Best Time to Buy and Sell Stock
 */

// @lc code=start
public class Solution {
    public int MaxProfit(int[] prices) {
        int min = prices[0];
        int profit = 0;
        for(int i = 1; i< prices.Length ; i++){
            if(prices[i] < min)
                min = prices[i];
            profit = Math.Max(profit, prices[i] - min);         
        }
        return profit;
    }
}
// @lc code=end

