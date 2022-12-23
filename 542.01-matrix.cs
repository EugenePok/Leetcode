/*
 * @lc app=leetcode id=542 lang=csharp
 *
 * [542] 01 Matrix
 */

// @lc code=start
public class Solution
{
    public int[][] UpdateMatrix(int[][] mat)
    {
        int m = mat.Length;
        int n = mat[0].Length;
        int max = m + n;
        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (mat[r][c] == 0) continue;
                int top = max; int left = max;
                if (r - 1 >= 0) top = mat[r - 1][c];
                if (c - 1 >= 0) left = mat[r][c - 1];
                mat[r][c] = Math.Min(top, left) + 1;
            }
        }
        for (int r = m - 1; r >= 0; r--)
        {
            for (int c = n - 1; c >= 0; c--)
            {
                if (mat[r][c] == 0) continue;
                int btm = max; int right = max;
                if (r + 1 < m) btm = mat[r + 1][c];
                if (c + 1 < n) right = mat[r][c + 1];
                mat[r][c] = new int[] { btm + 1, right + 1, mat[r][c] }.Min();
            }
        }
        return mat;
    }
}
// @lc code=end

