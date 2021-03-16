using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.DynamicProgramming
{
    public partial class DynamicProgrammingTest
    {
        [Theory]
        [InlineData("abcde", "ace", 3)]
        [InlineData("abc", "abc", 3)]
        [InlineData("abc", "def", 0)]
        void LongestCommonSubsequence(string text1, string text2, int assert)
        {
            var result = _solution.LongestCommonSubsequence_DP(text1, text2);

            Assert.Equal(result, assert);
        }
    }
}
