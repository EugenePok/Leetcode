public class MyQueue {
    Stack<int> input;
    Stack<int> output;
    public MyQueue() {
        input = new Stack<int>();
        output = new Stack<int>();
    }
    
    public void Push(int x) {
        input.Push(x);
    }
    
    public int Pop() {
        Peek();
        return output.Pop();
    }
    
    public int Peek() {
        if(output.Count == 0)
            while(input.Count > 0)
                output.Push(input.Pop());
        return output.Peek();
    }
    
    public bool Empty() {
        return input.Count == 0 && output.Count == 0;
    }
}
