using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(2, 2)]
        [InlineData(3, 3)]
        [InlineData(4, 5)]
        public void ClimbStairs(int n,int assert)
        {
            var result = _solution.ClimbStarirs_DP(n);

            Assert.Equal(result, assert);
        }
    }
}
