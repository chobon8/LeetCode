/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
 */

// @lc code=start

using System.Collections.Generic;

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
        InorderDFS(root, result);
        return result;
    }

    private void InorderDFS(TreeNode node,IList<int> result)
    {
        if (node == null) return;

        if (node.left != null)
        {
            InorderDFS(node.left, result);
        }

        result.Add(node.val);

        if (node.right != null)
        {
            InorderDFS(node.right, result);
        }
    }
}
// @lc code=end

