using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(new []{ 7, 1, 5, 3, 6, 4 }, 5)]
        [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfit(int[] prices,int assert)
        {
            var result = _solution.MaxProfit_DP(prices);

            Assert.Equal(result, assert);
        }
    }
}
