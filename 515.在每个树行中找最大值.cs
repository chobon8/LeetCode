/*
 * @lc app=leetcode.cn id=515 lang=csharp
 *
 * [515] 在每个树行中找最大值
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public IList<int> LargestValues(TreeNode root)
    {
        return LargestValues_DFS(root);
    }

    public IList<int> LargestValues_DFS(TreeNode root)
    {
        IList<int> result = new List<int>();

        LargestValuesDFS(root,0, (level, max) =>
        {
            if(result.Count == level) result.Add(int.MinValue);
            result[level] = Math.Max(result[level], max);
        });

        return result;
    }

    private void LargestValuesDFS(TreeNode node, int level,Action<int,int> process)
    {
        if(node == null) return;

        process(level, node.val);

        LargestValuesDFS(node.left, level + 1, process);
        LargestValuesDFS(node.right, level + 1, process);
    }

    public IList<int> LargestValues_BFS(TreeNode root)
    {
        IList<int> result = new List<int>();

        if(root == null) return result;

        IList<TreeNode> queue = new List<TreeNode>{ root };

        while (queue.Any())
        {
            IList<TreeNode> nodes = new List<TreeNode>();

            int max = int.MinValue;

            foreach (var item in queue)
            {
                if (item.left != null) nodes.Add(item.left);
                if (item.right != null) nodes.Add(item.right);
                max = Math.Max(max, item.val);
            }

            result.Add(max);
            queue = nodes;
        }

        return result;
    }
}
// @lc code=end

