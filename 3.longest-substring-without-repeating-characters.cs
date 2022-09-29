/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0) return 0;
        int longestLengthFoundSoFar = 0;
        Dictionary<char,int> LastIndexFoundForThisChar = new Dictionary<char, int>();
        int lastDistinctCharIndex = 0;
        for(int i = 0; i < s.Length; i++){
            if(LastIndexFoundForThisChar.Keys.Contains(s[i]))
                lastDistinctCharIndex 
                = Math.Max(LastIndexFoundForThisChar[s[i]] + 1 , lastDistinctCharIndex);
            LastIndexFoundForThisChar[s[i]] = i;
            longestLengthFoundSoFar = Math.Max(longestLengthFoundSoFar, i - lastDistinctCharIndex + 1);
        }
        return longestLengthFoundSoFar;
    }
}
// @lc code=end

