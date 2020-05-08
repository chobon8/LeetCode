using System;
using System.Collections.Generic;
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
            var dfsResult = _solution.GenerateParenthesis_DFS(n);

            Assert.Equal(dfsResult, assert);
        }
    }
}
