/*
 * @lc app=leetcode.cn id=543 lang=csharp
 *
 * [543] 二叉树的直径
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
public class Solution {
    int max = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        DFS(root);
        return max;
    }

    public int DFS(TreeNode root)
    {
        int leftStep = 0;
        int rightStep = 0;
        if(root == null) 
        {
            return 0;
        }

        if(root.left!=null) 
        {
            leftStep = DFS(root.left);
            leftStep++;
        }
        if(root.right!=null) 
        {
            rightStep = DFS(root.right);
            rightStep++;
        }
        int maxStep = Math.Max(leftStep,rightStep);
        max = Math.Max(max,leftStep+rightStep);
        return maxStep;
    }
}
// @lc code=end

