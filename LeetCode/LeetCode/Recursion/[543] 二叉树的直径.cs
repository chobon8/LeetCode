using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Recursion
    {
        static int max = 0;
        public static int DiameterOfBinaryTree(TreeNode root)
        {
            DSF(root);
            return max;
        }

        public static int DSF(TreeNode node)
        {
            int leftStep = 0;
            int rightStep = 0;
            if (node == null)
            {
                return 0;
            }

            if (node.left != null)
            {
                leftStep = DiameterOfBinaryTree(node.left);
                leftStep++;
            }
            if (node.right != null)
            {
                rightStep = DiameterOfBinaryTree(node.right);
                rightStep++;
            }
            int maxStep = System.Math.Max(leftStep, rightStep);
            max = System.Math.Max(max, leftStep + rightStep);
            return maxStep;
        }
    }
}
