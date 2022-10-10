/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        int l = 0;
        int r = s.Length - 1;
        char left = Char.ToLower(s[l]);
        char right = Char.ToLower(s[r]);
        while(l < r){
            if(Char.IsLetterOrDigit(left) && Char.IsLetterOrDigit(right)){
                if (left != right) return false;
                else {
                    left = Char.ToLower(s[++l]);
                    right = Char.ToLower(s[--r]);
                    continue;
                }
            }
            if(!Char.IsLetterOrDigit(left))
                left = Char.ToLower(s[++l]);
            if(!Char.IsLetterOrDigit(right))
                right = Char.ToLower(s[--r]);
        }
        return true;
    }
}
// @lc code=end

