/*
 * @lc app=leetcode id=234 lang=csharp
 *
 * [234] Palindrome Linked List
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        ListNode fast = head;
        ListNode newHead = null;
        ListNode next;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            next = head.next;
            head.next = newHead;
            newHead = head;
            head = next;
        }
        if (fast != null) head = head.next;
        while (newHead != null && head != null)
        {
            if (newHead.val != head.val) return false;
            newHead = newHead.next;
            head = head.next;
        }
        return true;
    }
}
// @lc code=end

