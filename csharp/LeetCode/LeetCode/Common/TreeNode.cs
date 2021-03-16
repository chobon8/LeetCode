using System;
using System.Collections.Generic;
using System.Text;


public class TreeNode
{

    public static readonly TreeNode TreeV0 = new TreeNode(0);
    public static readonly TreeNode TreeV1 = new TreeNode(1);
    public static readonly TreeNode TreeV2 = new TreeNode(2);
    public static readonly TreeNode TreeV3 = new TreeNode(3);
    public static readonly TreeNode TreeV4 = new TreeNode(4);
    public static readonly TreeNode TreeV5 = new TreeNode(5);
    public static readonly TreeNode TreeV6 = new TreeNode(6);
    public static readonly TreeNode TreeV7 = new TreeNode(7);

    public int val;

    public TreeNode left;

    public TreeNode right;

    public TreeNode(int x)
    {
        val = x;
    }
}


