/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0)) return false;
        int newNum = 0;
        while (x > newNum)
        {
            newNum = newNum * 10 + x % 10;
            x = x / 10;
        }
        return x == newNum || newNum / 10 == x;
    }

}
// @lc code=end

