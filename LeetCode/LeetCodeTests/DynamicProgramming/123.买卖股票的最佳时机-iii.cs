using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(new[] { 3, 3, 5, 0, 0, 3, 1, 4 }, 6)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitIII(int[] prices, int assert)
        {
            var result = _solution.MaxProfitIII_DP(prices);

            Assert.Equal(result, assert);
        }
    }
}
