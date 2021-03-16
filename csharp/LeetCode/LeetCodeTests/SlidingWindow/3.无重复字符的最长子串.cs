using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.SlidingWindow
{
    public partial class SlidingWindowTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        void LengthOfLongestSubstring(string s, int assert)
        {
            var swResult = _solution.LengthOfLongestSubstring_SW(s);

            Assert.Equal(swResult, assert);
        }
    }
}
