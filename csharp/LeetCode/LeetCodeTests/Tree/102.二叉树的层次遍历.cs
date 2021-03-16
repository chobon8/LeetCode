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

            var dfsResult = _solution.LevelOrder_DFS(root);

            Assert.Equal(bfsResult, assert);

            Assert.Equal(dfsResult, assert);
        }


        public static IEnumerable<object[]> GetLevelOrderTreeNodeRoot()
        {

            TreeNode v3 = new TreeNode(3);
            TreeNode v9 = new TreeNode(9);
            TreeNode v20 = new TreeNode(20);
            TreeNode v15 = new TreeNode(15);
            TreeNode v7 = new TreeNode(7);

            v3.left = v9;
            v3.right = v20;
            v20.left = v15;
            v20.right = v7;

            var allData = new List<object[]>
            {
                new object[] { v3, new List<IList<int>> {new List<int>{3}, new List<int>{9,20}, new List<int>{15,7}}}
            };

            return allData;
        }
    }
}
