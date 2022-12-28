/*
 * @lc app=leetcode id=150 lang=csharp
 *
 * [150] Evaluate Reverse Polish Notation
 */

// @lc code=start
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        foreach (var s in tokens)
        {
            switch (s)
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                    int right = stack.Pop();
                    int left = stack.Pop();
                    stack.Push(left - right);
                    break;
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                    int r = stack.Pop();
                    int l = stack.Pop();
                    stack.Push(l / r);
                    break;
                default:
                    stack.Push(Convert.ToInt32(s));
                    break;
            }
        }
        return stack.Pop();
    }

}
// @lc code=end

