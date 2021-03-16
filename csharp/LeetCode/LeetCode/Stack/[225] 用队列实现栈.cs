using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class MyStack
    {
        private readonly Queue<int> queue = null;
        private readonly Queue<int> reverseQueue = null;

        private int count = 0;

        public MyStack()
        {
            queue = new Queue<int>();
            reverseQueue = new Queue<int>();
        }

        public void Push(int x)
        {
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

        public int Pop()
        {
            count--;
            return reverseQueue.Dequeue();
        }

        public int Top()
        {
            if (count <= 0) return 0;
            return reverseQueue.Peek();
        }

        public bool Empty() => count <= 0;

    }
}
