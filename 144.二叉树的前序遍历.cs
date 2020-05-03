/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
 *
 * https://leetcode-cn.com/problems/binary-tree-preorder-traversal/description/
 *
 * algorithms
 * Medium (64.96%)
 * Likes:    246
 * Dislikes: 0
 * Total Accepted:    98.3K
 * Total Submissions: 150.3K
 * Testcase Example:  '[1,null,2,3]'
 *
 * 给定一个二叉树，返回它的 前序 遍历。
 * 
 * 示例:
 * 
 * 输入: [1,null,2,3]  
 * ⁠  1
 * ⁠   \
 * ⁠    2
 * ⁠   /
 * ⁠  3 
 * 
 * 输出: [1,2,3]
 * 
 * 
 * 进阶: 递归算法很简单，你可以通过迭代算法完成吗？
 * 
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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> reuslt = new List<int>();
        if (root == null) return reuslt;

    }

    public void PreorderDfs(TreeNode root, IList<int> result)
    {

    }
}
// @lc code=end

