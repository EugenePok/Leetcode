/*
 * @lc app=leetcode id=844 lang=csharp
 *
 * [844] Backspace String Compare
 */

// @lc code=start
public class Solution
{
    public bool BackspaceCompare(string S, string T)
    {
        int i = S.Length - 1, j = T.Length - 1, back;
        while (true)
        {
            back = 0;
            while (i >= 0 && (back > 0 || S[i] == '#'))
            {
                back += S[i] == '#' ? 1 : -1;
                i--;
            }
            back = 0;
            while (j >= 0 && (back > 0 || T[j] == '#'))
            {
                back += T[j] == '#' ? 1 : -1;
                j--;
            }
            if (i >= 0 && j >= 0 && S[i] == T[j])
            {
                i--;
                j--;
            }
            else
                break;
        }
        return i == j && i == -1;
    }
}
// @lc code=end

