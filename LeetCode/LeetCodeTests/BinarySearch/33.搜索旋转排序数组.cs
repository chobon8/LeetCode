using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.BinarySearch
{
    public partial class BinarySearchTest
    {
        [Theory]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [InlineData(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [InlineData(new[] { 1 }, 1, 0)]
        void Search(int[] nums, int target,int assert)
        {
            var result = _solution.Search_BinarySearch(nums, target);

            Assert.Equal(result,assert);
        }
    }
}
