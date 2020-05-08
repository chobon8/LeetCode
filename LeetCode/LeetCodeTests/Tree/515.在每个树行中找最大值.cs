using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Tree
{
    public partial class TreeTest
    {
        [Theory]
        [MemberData(nameof(GetLargestValuesTreeNodeRoot))]
        void LargestValues(TreeNode root,IList<int> assert)
        {
            var dfsResult = _solution.LargestValues_DFS(root);

            var bfsResult = _solution.LargestValues_BFS(root);

            Assert.Equal(dfsResult,assert);

            Assert.Equal(bfsResult, assert);
        }

        public static IEnumerable<object[]> GetLargestValuesTreeNodeRoot()
        {

            var v1 = new TreeNode(1);
            var v2 = new TreeNode(3);
            var v3 = new TreeNode(2);
            var v4 = new TreeNode(5);
            var v5 = new TreeNode(3);
            var v6 = new TreeNode(9);

            v1.left = v2;
            v1.right = v3;
            v2.left = v4;
            v2.right = v5;
            v3.right = v6;

            var allData = new List<object[]>
            {
                new object[] { v1, new List<int> {1, 3, 9}}
            };

            return allData;
        }
    }
}
