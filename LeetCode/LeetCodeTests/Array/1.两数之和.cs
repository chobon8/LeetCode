using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Array
{
    public partial class ArrayTest
    {
        [Theory]
        [InlineData(new[]{ 2, 7, 11, 15 },9,new[] { 0, 1 })]
        void TwoSum(int[] nums, int target,int[] assert)
        {
            var hashtableResult = _solution.TwoSum(nums, target);

            System.Array.Sort(hashtableResult);

            Assert.Equal(hashtableResult, assert);
        }
    }
}
