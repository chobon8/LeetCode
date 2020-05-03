using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.SlidingWindow
{
    public partial class SlidingWindowTest
    {
        [Theory]
        [InlineData("ADOBECODEBANC", "ABC", "BANC")]
        void MinWindow(string s, string t, string assert)
        {
            var swResult = _solution.MinWindow(s, t);

            Assert.Equal(swResult, assert);
        }
    }
}
