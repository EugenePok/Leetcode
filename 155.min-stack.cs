/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class MinStack {

    class Node{
        public int Min;
        public int Val;
        public Node Next;
        public Node(int val, int min, Node next = null)
        {
            Min = min;
            Val = val;
            Next = next;
        }
    }

    private Node head;

    public MinStack() {
        
    }
    
    public void Push(int val) {
        if(head == null)
            head = new Node(val, val);
        else
            head = new Node(val, Math.Min(head.Min, val), head);
    }
    
    public void Pop() {
        head = head.Next;
    }
    
    public int Top() {
        return head.Val;    
    }
    
    public int GetMin() {
        return head.Min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

