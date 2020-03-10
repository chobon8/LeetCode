/*
 * @lc app=leetcode.cn id=234 lang=csharp
 *
 * [234] 回文链表
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
    public bool IsPalindrome1(ListNode head) {
        Stack<ListNode> stack = new Stack<ListNode>();
        if(head==null) return true;
        ListNode node = head;
        while(node.next != null)
        {
            stack.Push(node);
            node = node.next;
        }
        while(stack.Count > 0)
        {
            
            head = head.next;
            if(stack.Pop().val != head.val)
                return false;
        }
        return true;
    }
}
// @lc code=end

