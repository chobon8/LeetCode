using System.Collections.Generic;
using System.Collections;
/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        Dictionary<int,ListNode> dict = new Dictionary<int, ListNode>();
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
// @lc code=end

