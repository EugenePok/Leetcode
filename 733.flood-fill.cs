/*
 * @lc app=leetcode id=733 lang=csharp
 *
 * [733] Flood Fill
 */

// @lc code=start
public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color) {
        if(image[sr][sc] != color)
            dfs(image, sr , sc ,image[sr][sc], color);
        return image;
    }

    public void dfs(int[][] image, int sr, int sc, int targetColor, int newColor){
        if(sr < 0 || sc < 0 
        || sr > image.Length - 1 
        || sc > image[0].Length - 1
        || image[sr][sc] != targetColor)
            return;
        image[sr][sc] = newColor;
        dfs(image, sr - 1 , sc ,targetColor, newColor);
        dfs(image, sr, sc - 1 ,targetColor, newColor);
        dfs(image, sr + 1, sc ,targetColor, newColor);
        dfs(image, sr, sc + 1 ,targetColor, newColor);
    }
}
// @lc code=end

