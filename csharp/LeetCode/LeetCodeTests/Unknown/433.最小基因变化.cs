using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Unknown
{
    public partial class UnknownTest
    {
        [Theory]
        [InlineData("AACCGGTT", "AACCGGTA", new[] { "AACCGGTA" }, 1)]
        [InlineData("AACCGGTT", "AAACGGTA", new[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" }, 2)]
        [InlineData("AAAAACCC", "AACCCCCC", new[] { "AAAACCCC", "AAACCCCC", "AACCCCCC" }, 3)]
        [InlineData("AACCTTGG", "AATTCCGG", new[] { "AATTCCGG", "AACCTGGG", "AACCCCGG", "AACCTACC" }, -1)]
        [InlineData("AAAACCCC", "CCCCCCCC", new[] { "AAAACCCA", "AAACCCCA", "AACCCCCA", "AACCCCCC", "ACCCCCCC", "CCCCCCCC", "AAACCCCC", "AACCCCCC" }, 4)]
        void MinMutation(string start,string end,string[] bank,int assert)
        {
            var bfsResult = _solution.MinMutation_BFS(start, end, bank);

            var dfsResult = _solution.MinMutation_DFS(start, end, bank);

            Assert.Equal(bfsResult, assert);

            Assert.Equal(dfsResult, assert);
        }
    }
}
