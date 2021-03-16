using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Tree
{
    public partial class TreeTest
    {
        [Theory]   
        [MemberData(nameof(GetInorderTreeNodeRoot))]
        void InorderTraversal(TreeNode root,IList<int> assert)
        {
            var result = _solution.InorderTraversal(root);

            Assert.Equal(result, assert);
        }


        public static IEnumerable<object[]> GetInorderTreeNodeRoot()
        {

            TreeNode.TreeV1.right = TreeNode.TreeV2;
            TreeNode.TreeV1.left = null;
            TreeNode.TreeV2.left = TreeNode.TreeV3;
            TreeNode.TreeV2.right = null;

            var allData = new List<object[]>
            {
                new object[] { TreeNode.TreeV1, new List<int> {1, 3, 2}}
            };

            return allData;
        }
    }
}
