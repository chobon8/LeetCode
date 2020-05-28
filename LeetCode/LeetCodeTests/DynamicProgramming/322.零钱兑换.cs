using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 5 }, 11, 3)]
        [InlineData(new[] { 2 }, 3, -1)]
        [InlineData(new[] { 1 }, 0, 0)]
        [InlineData(new []{ 186, 419, 83, 408 }, 6249, 20)]
        public void CoinChange(int[] coins,int amount,int assert)
        {
            var result = _solution.CoinChange_DP(coins, amount);

            Assert.Equal(result, assert);
        }
    }
}
