/*
 * @lc app=leetcode id=200 lang=csharp
 *
 * [200] Number of Islands
 */

// @lc code=start
public class Solution
{
    int m, n;
    public int NumIslands(char[][] grid)
    {
        int result = 0;
        m = grid.Length;
        if (m == 0) return 0;
        n = grid[0].Length;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (grid[i][j] != '0')
                {
                    Shrink(grid, i, j);
                    result++;
                }
            }
        }
        return result;
    }

    public void Shrink(char[][] grid, int i, int j)
    {
        if (i < 0 || j < 0 || i >= m || j >= n || grid[i][j] != '1') return;
        grid[i][j] = '0';
        Shrink(grid, i + 1, j);
        Shrink(grid, i, j + 1);
        Shrink(grid, i - 1, j);
        Shrink(grid, i, j - 1);
    }
}
// @lc code=end

