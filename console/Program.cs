using System.Collections;

MyQueue myQueue = new MyQueue();
myQueue.push(1); // queue is: [1]
myQueue.push(2); // queue is: [1, 2] (leftmost is front of the queue)
myQueue.peek(); // return 1
myQueue.push(3);
myQueue.pop(); // return 1, queue is [2]
myQueue.empty(); // return false
