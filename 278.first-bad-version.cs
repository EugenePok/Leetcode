/*
 * @lc app=leetcode id=278 lang=csharp
 *
 * [278] First Bad Version
 */

// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int start = 1;
        while(start < n){
            int mid = start + (n-start)/2;
            if(IsBadVersion(mid))
                n = mid;
            else
                start = mid + 1;
        }
        return start;
    }
}
// @lc code=end

