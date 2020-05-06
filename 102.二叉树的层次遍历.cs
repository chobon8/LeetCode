/*
 * @lc app=leetcode.cn id=102 lang=csharp
 *
 * [102] 二叉树的层次遍历
 */

// @lc code=start

using System;
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
public partial class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        return LevelOrder_BFS(root);
    }

    public IList<IList<int>> LevelOrder_DFS(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        HashSet<TreeNode> visited = new HashSet<TreeNode>();

        LevelOrderDFS(root, 0,(val,level) =>
        {
            result[level].Add(val);
        });
        return result;

    }

    private void LevelOrderDFS(TreeNode node,int level, Action<int,int> action)
    {

        throw new NullReferenceException();
    }

    public IList<IList<int>> LevelOrder_BFS(TreeNode root)
    {
        IList<IList<int>> result = new List<IList<int>>();

        HashSet<TreeNode> visited = new HashSet<TreeNode>();

        LevelOrderBFS(root, 0, (node) => visited.Contains(node),(node, level) =>
        {
            result[level].Add(node.val);
            visited.Add(node);
        });

        return result;
    }

    private void LevelOrderBFS(TreeNode node, int level, Func<TreeNode, bool> isVisited, Action<TreeNode, int> action)
    {
        if (node == null) return;
        action(node, 0);
        LevelOrderBFS(node.left, level + 1, isVisited, action);
        LevelOrderBFS(node.right, level + 1, isVisited, action);
    }
}
// @lc code=end

