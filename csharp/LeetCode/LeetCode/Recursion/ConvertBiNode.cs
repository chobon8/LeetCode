using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Recursion
    {
        private static TreeNode head = new TreeNode(0);
        public static TreeNode ConvertBiNode(TreeNode root)
        {
            if (root == null) return null;
            DFS(root, head);
            return head.right;
        }

        private static TreeNode DFS(TreeNode node,TreeNode res)
        {
            if (node != null)
            {
                res = DFS(node.left,res);

                res.left = null;
                res.right = node;

                res = DFS(node.right, node);
            }

            return res;
        }
    }
}
