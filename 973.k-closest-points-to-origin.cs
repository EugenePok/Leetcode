/*
 * @lc app=leetcode id=973 lang=csharp
 *
 * [973] K Closest Points to Origin
 */

// @lc code=start
public class Solution
{
    public int[][] KClosest(int[][] points, int k)
    {
        PriorityQueue<int[], double> myQueue = new PriorityQueue<int[], double>();
        foreach (var p in points)
            myQueue.Enqueue(p, p[0] * p[0] + p[1] * p[1]);
        
        int[][] result = new int[k][];
        while (k > 0)
            result[--k] = myQueue.Dequeue();
        return result;
    }
}
// @lc code=end

