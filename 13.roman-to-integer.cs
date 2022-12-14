/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;
        s = s.Replace("IV", "IIII").Replace("IX", "VIIII")
        .Replace("XL", "XXXX").Replace("XC", "LXXXX")
        .Replace("CD", "CCCC").Replace("CM", "DCCCC");
        foreach (var c in s)
        {
            result += dict[c];
        }
        return result;
    }
}
// @lc code=end

