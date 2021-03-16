using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(2, new[] { 2, 4, 1 }, 2)]
        [InlineData(2, new[] { 3, 2, 6, 5, 0, 3 }, 7)]
        public void MaxProfitIV_DP(int k, int[] prices, int assert)
        {
            var result = _solution.MaxProfitIV_DP(k, prices);

            Assert.Equal(result, assert);
        }
    }
}
