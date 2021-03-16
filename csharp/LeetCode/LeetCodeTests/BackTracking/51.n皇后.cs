using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace LeetCodeTests.BackTracking
{
    public partial class BackTrackingTest
    {
        [Theory]
        [InlineData(4, new [] { "..Q.", "Q...", "...Q", ".Q.." }, new[] { ".Q..", "...Q", "Q...", "..Q." })]
        public void SolveNQueens(int n,params string[][] assert)
        {
            var result = _solution.SolveNQueens_Backtracking(n);

            IEqualityComparer<string[][]> comparer = new Comparer();

            Assert.Equal(result.Select(x => x.ToArray()).ToArray(), assert, comparer);
        }

    }
}
