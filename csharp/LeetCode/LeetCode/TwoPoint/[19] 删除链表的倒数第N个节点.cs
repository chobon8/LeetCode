using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class TwoPoint
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head;
            ListNode slow = head;
            for (int i = 0; i < n; n++)
            {
                fast = fast.next;
            }
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}
