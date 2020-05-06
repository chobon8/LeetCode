using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            //TreeNode v0 = new TreeNode(0);
            //TreeNode v1 = new TreeNode(1);
            //TreeNode v2 = new TreeNode(2);
            //TreeNode v3 = new TreeNode(3);
            //TreeNode v4 = new TreeNode(4);
            //TreeNode v5 = new TreeNode(5);
            //TreeNode v6 = new TreeNode(6);
            //TreeNode v7 = new TreeNode(7);

            //v4.left = v2;
            //v4.right = v5;
            //v2.left = v1;
            //v2.right = v3;
            //v1.left = v0;
            //v5.right = v6;
            //v6.right = v7;

            //v1.left = v2;
            //v1.right = v3;
            //v2.left = v4;
            //v2.right = v5;

            //v1.right = v2;
            //v2.left = v3;

            //int step = Recursion.DiameterOfBinaryTree(v1);


            //var result = Math.Reverse(-2147483648);

            //var result = String.CompressString('abbccd');

            //MyStack stack = new MyStack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);

            //var num4 = stack.Pop();
            //var num3 = stack.Pop();
            //var num2 = stack.Pop();
            //var num1 = stack.Pop();

            //int{}{} grid1 = {new{} {2, 1, 1}, new{} {1, 1, 0}, new{} {0, 1, 1}};

            //int{}{} grid2 = {new{} {2, 1, 1}, new{} {0, 1, 1}, new{} {1, 0, 1}};

            //int{}{} grid3 = {new{} {2, 1, 0, 2}};

            //int{}{} grid4 = {new{} {1}, new{} {1}, new{} {1}, new{} {1}};

            //int result1 = Hashtable.OrangesRotting(grid1);

            //int result2 = Hashtable.OrangesRotting(grid2);

            //int result3 = Hashtable.OrangesRotting(grid3);

            //int result4 = Hashtable.OrangesRotting(grid4);


            //var result = Heap.GetLeastNumbers(new{} {3, 2, 1, 5, 7, 6, 9, 2}, 2);

            //var result = SlidingWindow.MinWindow('a', 'aa');

            //int x = 9;

            //Console.WriteLine(x % 2);
            //Console.WriteLine(x & (2-1));

            char[][] board =
            {
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}, 
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'}, 
                new[] {'p', 'p', '.', 'R', '.', 'p', 'B', '.'},
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}, 
                new[] {'.', '.', '.', 'B', '.', '.', '.', '.'},
                new[] {'.', '.', '.', 'p', '.', '.', '.', '.'}, 
                new[] {'.', '.', '.', '.', '.', '.', '.', '.'}
            };
            DepthFirstSearch.NumRookCaptures(board);
        }
    }
}
