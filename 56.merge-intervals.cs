/*
 * @lc app=leetcode id=56 lang=csharp
 *
 * [56] Merge Intervals
 */

// @lc code=start
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        if (intervals.Length < 2)
            return intervals;
        Array.Sort(intervals, (i1, i2) => i1[0].CompareTo(i2[0]));

        List<int[]> result = new();
        int[] newInterval = intervals.First();
        result.Add(newInterval);
        foreach (var interval in intervals)
        {
            if (interval[0] > newInterval[1])
            {
                newInterval = interval;
                result.Add(interval);
            }
            else if (newInterval[1] < interval[1])
                newInterval[1] = interval[1];
        }
        return result.ToArray();
    }

}
// @lc code=end

