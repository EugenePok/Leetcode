/*
 * @lc app=leetcode id=57 lang=csharp
 *
 * [57] Insert Interval
 */

// @lc code=start
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> result = new List<int[]>();
        foreach (var interval in intervals)
        {
            if (newInterval[1] < interval[0])
            {
                result.Add(newInterval);
                newInterval = interval;
            }
            else if (interval[1] < newInterval[0])
            {
                result.Add(interval);
            }
            else
            {
                newInterval[0] = Math.Min(newInterval[0], interval[0]);
                newInterval[1] = Math.Max(newInterval[1], interval[1]);
            }
        }
        result.Add(newInterval);
        return result.ToArray();
    }
}
// @lc code=end

