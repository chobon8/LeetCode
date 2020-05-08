using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCodeTests.String
{
    public partial class StringTest
    {
        [Theory]
        [InlineData(3,new[]{"((()))", "(()())", "(())()", "()(())", "()()()"})]
        void GenerateParenthesis(int n, string[] assert)
        {
            var dfsResult = _solution.GenerateParenthesis_DFS(n).ToArray();

            var bfsResult = _solution.GenerateParenthesis_BFS(n).ToArray();

            Assert.Equal(dfsResult, assert);

            Assert.Equal(bfsResult, assert);
        }
    }
}
