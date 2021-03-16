/*
 * @lc app=leetcode.cn id=19 lang=csharp
 *
 * [19] 删除链表的倒数第N个节点
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode fast = head;
        ListNode slow = head;
        for(int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        //删头节点
        if(fast == null)
        {
            slow = slow.next;
            return slow;
        }
            
        while(fast != null)
        {
            if(fast.next == null)
            {
                slow.next = slow.next?.next;
                break;
            }
            fast = fast.next;
            slow = slow.next;
        }
        
        return head;
    }
}
// @lc code=end

