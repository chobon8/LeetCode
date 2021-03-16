/*
 * @lc app=leetcode.cn id=225 lang=csharp
 *
 * [225] 用队列实现栈
 */

// @lc code=start
public class MyStack {

    private readonly Queue<int> queue = null;
    private readonly Queue<int> reverseQueue = null;

    private int count = 0;

    /** Initialize your data structure here. */
    public MyStack() {
        queue = new Queue<int>();
        reverseQueue = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        queue.Clear();
        while (reverseQueue.Count > 0)
        {
            queue.Enqueue(reverseQueue.Dequeue());
        }

        reverseQueue.Enqueue(x);
        while (queue.Count > 0)
        {
            reverseQueue.Enqueue(queue.Dequeue());
        }
        
        count++;
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        count--;
        return reverseQueue.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        if (count <= 0) return 0;
        return reverseQueue.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return count <= 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
// @lc code=end

