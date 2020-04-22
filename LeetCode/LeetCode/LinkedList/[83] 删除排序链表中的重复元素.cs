using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using LeetCode.Common;

namespace LeetCode
{
    public partial class LinkedList
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            Dictionary<int, ListNode> dict = new Dictionary<int, ListNode>();
            ListNode node = head;
            while (node != null)
            {
                if (dict.ContainsKey(node.val))
                {
                    dict[node.val].next = node.next;
                }
                else
                {
                    dict[node.val] = node;
                }

                node = node.next;
            }
            return head;
        }
    }
}
