using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Tree
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            IList<int> result = new List<int>();
            DFS(root, result);
            return result;
        }

        public static void DFS(TreeNode node, IList<int> result)
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
}
