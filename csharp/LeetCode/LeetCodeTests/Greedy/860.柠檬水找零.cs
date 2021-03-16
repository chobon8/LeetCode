using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Greedy
{
    public partial class GreedyTest
    {
        [Theory]
        [InlineData(new[] { 5, 5, 10 }, true)]
        [InlineData(new[] { 10, 10 }, false)]
        [InlineData(new[] { 5, 5, 10, 10, 20 }, false)]
        public void LemonadeChange(int[] bills,bool assert)
        {
            var result = _solution.LemonadeChange_Greedy(bills);

            Assert.Equal(result, assert);
        }
    }
}
