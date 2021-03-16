using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Greedy
{
    public partial class GreedyTest
    {
        [Theory]
        [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 7)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 4)]
        [InlineData(new[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitII(int[] prices,int assert)
        {
            var result = _solution.MaxProfitII_Greedy(prices);

            Assert.Equal(result, assert);
        }
    }
}
