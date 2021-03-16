using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(3, 2, 3)]
        [InlineData(7, 3, 28)]
        [InlineData(3, 7, 28)]
        public void UniquePaths(int m, int n, int assert)
        {
            var result = _solution.UniquePaths_DP(m, n);

            Assert.Equal(result, assert);
        }
    }
}
