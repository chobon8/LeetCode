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
using System.Linq;
using System.Security.Cryptography;

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; 
 * }
 */
public partial class Solution {
    public IList<int> PreorderTraversal(TreeNode root)
    {
        return PreorderTraversal_Stack(root);
    }

    public IList<int> PreorderTraversal_DFS(TreeNode root)
    {
        List<int> reuslt = new List<int>();
        PreorderDFS(root, reuslt);
        return reuslt;
    }

    private void PreorderDFS(TreeNode root, IList<int> result)
    {
        if(root == null) return;
        //处理业务
        result.Add(root.val);
        //左节点
        PreorderDFS(root.left, result);
        //右节点
        PreorderDFS(root.right, result);
    }

    public IList<int> PreorderTraversal_Stack(TreeNode root)
    {
        IList<int> result = new List<int>();
        Stack<TreeNode> treeStack = new Stack<TreeNode>();

        while (root != null || treeStack.Count != 0)
        {
            if (root != null)
            {
                result.Add(root.val);
                treeStack.Push(root);
                root = root.left;
            }
            else
            {
                var node = treeStack.Pop();
                root = node.right;
            }
        }

        return result;
    }
}
// @lc code=end

