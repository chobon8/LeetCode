/*
 * @lc app=leetcode.cn id=237 lang=csharp
 *
 * [237] 删除链表中的节点
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
    public void DeleteNode(ListNode node) {
        ListNode temp = node.next;
        node.val = temp.val;
        node.next = temp.next;
    }
}
// @lc code=end

