/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
 */

// @lc code=start

using System.Collections.Generic;
using LeetCode.Common;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public partial class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> result = new List<int>();
        if(root == null) return result;
        DFS(root, result);
        return result;
    }

    private void DFS(TreeNode node,IList<int> result)
    {
        if (node.left != null)
        {
            DFS(node.left, result);
        }

        result.Add(node.val);

        if (node.right != null)
        {
            DFS(node.right, result);
        }
    }
}
// @lc code=end

