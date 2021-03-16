using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData(2, new []{ 0, 0, 0 },new []{ 0, 1, 0 }, new [] { 0, 0, 0 })]
        [InlineData(0, new []{ 1 })]
        [InlineData(0, new[] { 1 ,0 })]
        [InlineData(0, new[] { 0, 1 })]
        public void UniquePathsWithObstacles(int assert, params int[][] obstacleGrid)
        {
            var result = _solution.UniquePathsWithObstacles_DP(obstacleGrid);

            Assert.Equal(result, assert);
        }
    }
}
