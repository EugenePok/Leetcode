/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        int[] count = new int[26];
        foreach(var c in s) count[c - 'a']++;
        foreach(var c in t) if(count[c - 'a']-- == 0) return false;
        return true;
    }
}
// @lc code=end

