/*
 * @lc app=leetcode id=383 lang=csharp
 *
 * [383] Ransom Note
 */

// @lc code=start
public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        int[] wordCount = new int[26];
        foreach(char c in magazine){
            wordCount[c - 'a']++;
        }
        foreach(char c in ransomNote){
            if(--wordCount[c - 'a'] < 0)
                return false;
        }
        return true;
    }
}
// @lc code=end

