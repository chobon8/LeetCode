using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.BackTracking
{
    public partial class BackTrackingTest
    {
        [Theory]
        [InlineData(2.00000, 10, 1024.00000d)]
        [InlineData(2.10000, 3, 9.26100d)]
        [InlineData(2.00000, -2, 0.25000d)]
        [InlineData(2.00000, int.MinValue, 0.0d)]
        [InlineData(-1.00000, int.MinValue, 1.0d)]
        void MyPow(double x, int n, double assert)
        {
            var result = _solution.MyPow_BackTracking(x, n);

            Assert.Equal(result, assert, 5);
        }
    }
}
