using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Common;
using Xunit;

namespace LeetCodeTests.Tree
{
    public partial class TreeTest
    {
        [Theory]   
        [MemberData(nameof(GetTreeNodeRoot))]
        void InorderTraversal(TreeNode root,IList<int> assert)
        {
            var result = _solution.InorderTraversal(root);

            Assert.Equal(result, assert);
        }


        public static IEnumerable<object[]> GetTreeNodeRoot()
        {
            TreeNode v0 = new TreeNode(0);
            TreeNode v1 = new TreeNode(1);
            TreeNode v2 = new TreeNode(2);
            TreeNode v3 = new TreeNode(3);
            TreeNode v4 = new TreeNode(4);
            TreeNode v5 = new TreeNode(5);
            TreeNode v6 = new TreeNode(6);
            TreeNode v7 = new TreeNode(7);

            v1.right = v2;
            v1.left = null;
            v2.left = v3;
            v2.right = null;

            var allData = new List<object[]>
            {
                new object[] {v1, new List<int> {1, 3, 2}}
            };

            return allData;
        }
    }
}
