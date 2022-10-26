/*
 * @lc app=leetcode id=141 lang=csharp
 *
 * [141] Linked List Cycle
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode walker = head;
        ListNode runner = head;
        while(runner != null && runner.next != null){
            walker = walker.next;
            runner = runner.next.next;
            if(walker == runner) return true;
        }
        return false;
    }
}
// @lc code=end

