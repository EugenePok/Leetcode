/*
 * @lc app=leetcode id=207 lang=csharp
 *
 * [207] Course Schedule
 */

// @lc code=start
public class Solution
{
    public bool CanFinish(int numCourses, int[][] prerequisites)
    {
        bool[] canFinish = new bool[numCourses];
        bool[] waitingList = new bool[numCourses];
        for (int i = 0; i < numCourses; i++)
            if (!canFinishThisCourse(i, prerequisites, canFinish, waitingList))
                return false;
        return true;
    }

    bool canFinishThisCourse(int numCourses, int[][] prerequisites, bool[] canFinish, bool[] waitingList)
    {
        if (canFinish[numCourses]) return true;
        if (waitingList[numCourses]) return false;
        waitingList[numCourses] = true;
        foreach (var pair in prerequisites)
            if (pair[0] == numCourses && !canFinishThisCourse(pair[1], prerequisites, canFinish, waitingList))
                return false;
        waitingList[numCourses] = false;
        canFinish[numCourses] = true;
        return true;
    }
}
// @lc code=end

