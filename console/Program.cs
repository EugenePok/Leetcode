using System.Collections;

bool IsValid(string s) {
    if(s.Length%2 == 1) return false;
    Stack<char> stack = new Stack<char>();
    foreach(var c in s){
        if(new char[] {'(','[','{'}.Contains(c))
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


var result = IsValid("((");
Console.WriteLine(result);
//foreach(var i in result)
//    Console.WriteLine(i);
