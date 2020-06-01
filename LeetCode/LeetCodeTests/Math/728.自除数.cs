using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Math
{
    public partial class MathTest
    {
        [Theory]
        [InlineData(1,22,new []{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22 })]
        void SelfDividingNumbers(int left, int right, int[] assert)
        {
            var result = _solution.SelfDividingNumbers(left, right);

            Assert.Equal(result, assert);
        }
    }
}
