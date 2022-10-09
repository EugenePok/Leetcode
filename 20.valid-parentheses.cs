/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        if(s.Length%2 == 1) return false;
        Stack<char> stack = new Stack<char>();
        foreach(var c in s){
            if('(' == c || '[' == c || '{' == c)
                stack.Push(c);
            else{
                if(stack.Count == 0) return false;
                switch(c){
                    case ')' : 
                        if(stack.Peek() != '(') return false; break;
                    case ']' : 
                        if(stack.Peek() != '[') return false; break;
                    case '}' : 
                        if(stack.Peek() != '{') return false; break;
                }
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}
// @lc code=end

