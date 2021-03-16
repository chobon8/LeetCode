using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class LinkedList
    {
        //public static ListNode ReverseList(ListNode head)
        //{
        //    if (head == null || head.next == null) return head;
        //    ListNode node = ReverseList(head.next);

        //    head.next.next = head;
        //    head.next = null;

        //    return node;
        //}

        public static ListNode ReverseList(ListNode head)
        {
            if (head?.next == null) return head;
            Stack<ListNode> stack = new Stack<ListNode>();

            while (head.next != null)
            {
                stack.Push(head);
                head = head.next;
            }
            ListNode node = head;
            while (stack.Count > 0)
            {
                head.next = stack.Pop();
                head = head.next;
            }

            head.next = null;
            return node;
        }
    }
}
