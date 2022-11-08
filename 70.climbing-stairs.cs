/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
public class Solution {
    public int ClimbStairs(int n) {
        int a = 1, b = 1;
        while(n-- > 0){
            a = (b += a) - a;
        }
        return a;
    }
}
// @lc code=end

