/*
 * @lc app=leetcode id=994 lang=csharp
 *
 * [994] Rotting Oranges
 */

// @lc code=start
public class Solution
{
    public int OrangesRotting(int[][] grid)
    {
        if (grid[0].Length < 1) return -1;
        for (int i = 0; i < grid.Length; i++)
            for (int j = 0; j < grid[0].Length; j++)
                if (grid[i][j] == 2)
                    rotAdjacent(grid, i, j, 2);
        int result = 2;
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                if (grid[i][j] == 1) return -1;
                result = Math.Max(result, grid[i][j]);
            }
        }
        return result - 2;
    }

    public void rotAdjacent(int[][] grid, int i, int j, int minutes)
    {
        if (i < 0 || j < 0 || i >= grid.Length || j >= grid[0].Length
        || grid[i][j] == 0 || (grid[i][j] > 1 && grid[i][j] < minutes)) return;

        grid[i][j] = minutes;
        rotAdjacent(grid, i - 1, j, minutes + 1);
        rotAdjacent(grid, i + 1, j, minutes + 1);
        rotAdjacent(grid, i, j + 1, minutes + 1);
        rotAdjacent(grid, i, j - 1, minutes + 1);
    }
}
// @lc code=end

