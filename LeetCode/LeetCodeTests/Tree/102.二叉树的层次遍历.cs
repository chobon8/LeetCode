using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Tree
{
    public partial class TreeTest
    {
        [Theory]
        [MemberData(nameof(GetLevelOrderTreeNodeRoot))]
        void LevelOrder(TreeNode root, IList<IList<int>> assert)
        {
            var bfsResult = _solution.LevelOrder_BFS(root);

            //var stackResult = _solution.PreorderTraversal_Stack(root);

            Assert.Equal(bfsResult, assert);

            //Assert.Equal(stackResult, assert);
        }


        public static IEnumerable<object[]> GetLevelOrderTreeNodeRoot()
        {

            TreeNode.TreeV0.right = TreeNode.TreeV2;
            TreeNode.TreeV0.left = TreeNode.TreeV1;
            TreeNode.TreeV2.left = TreeNode.TreeV3;
            TreeNode.TreeV2.right = TreeNode.TreeV4;

            var allData = new List<object[]>
            {
                new object[] { TreeNode.TreeV1, new List<List<int>> {new List<int>{0}, new List<int>{1,2}, new List<int>{3,4}}}
            };

            return allData;
        }
    }
}
