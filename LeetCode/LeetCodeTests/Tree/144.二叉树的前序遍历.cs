using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Tree
{
    public partial class TreeTest
    {
        [Theory]
        [MemberData(nameof(GetPreorderTreeNodeRoot))]
        void PreorderTraversal(TreeNode root, IList<int> assert)
        {
            var dfsResult = _solution.PreorderTraversal_DFS(root);

            var stackResult = _solution.PreorderTraversal_Stack(root);

            Assert.Equal(dfsResult, assert);

            Assert.Equal(stackResult,assert);
        }


        public static IEnumerable<object[]> GetPreorderTreeNodeRoot()
        {

            TreeNode.TreeV1.right = TreeNode.TreeV2;
            TreeNode.TreeV1.left = null;
            TreeNode.TreeV2.left = TreeNode.TreeV3;
            TreeNode.TreeV2.right = null;

            var allData = new List<object[]>
            {
                new object[] { TreeNode.TreeV1, new List<int> {1, 2, 3}}
            };

            return allData;
        }
    }
}
