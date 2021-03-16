using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Greedy
{
    public partial class GreedyTest
    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 1, 1 }, 1)]
        [InlineData(new[] { 1, 2}, new[] { 1, 2, 3 }, 2)]
        public void FindContentChildren(int[] g, int[] s, int assert)
        {
            var result = _solution.FindContentChildren_Greedy(g, s);

            Assert.Equal(result, assert);
        }
    }
}
