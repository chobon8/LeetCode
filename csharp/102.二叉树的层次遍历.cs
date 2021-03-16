/*
 * @lc app=leetcode.cn id=102 lang=csharp
 *
 * [102] 二叉树的层次遍历
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

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
        List<IList<int>> result = new List<IList<int>>();

        HashSet<TreeNode> visited = new HashSet<TreeNode>();

        LevelOrderDFS(root, 0, (node) => visited.Contains(node), (node, level) =>
        {
            if (result.Count == level)
            {
                result.Add(new List<int>());
            }

            result[level].Add(node.val);
            visited.Add(node);
        });

        return result;

    }

    private void LevelOrderDFS(TreeNode node, int level, Func<TreeNode, bool> isVisited, Action<TreeNode, int> action)
    {
        if (node == null || isVisited(node)) return;
        action(node, level);
        LevelOrderDFS(node.left, level + 1, isVisited, action);
        LevelOrderDFS(node.right, level + 1, isVisited, action);
    }

    public IList<IList<int>> LevelOrder_BFS(TreeNode root)
    {
        List<IList<int>> result = new List<IList<int>>();

        List<TreeNode> queue = new List<TreeNode> {root};

        while (queue.Any())
        {
            List<int> child = new List<int>();
            List<TreeNode> nodes = new List<TreeNode>();
            foreach (var node in queue)
            {
                child.Add(node.val);
                if(node.left != null) 
                    nodes.Add(node.left);
                if(node.right != null) 
                    nodes.Add(node.right);
            }
            result.Add(child);
            queue = nodes;
        }

        return result;
    }
}
// @lc code=end

