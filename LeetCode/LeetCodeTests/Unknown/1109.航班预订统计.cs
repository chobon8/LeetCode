using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Unknown
{
    public partial class UnknownTest
    {
        [Theory]
        [InlineData(new[] { 10, 55, 45, 25, 25 } ,5 ,new[] { 1, 2, 10 }, new[]{ 2, 3, 20 },new []{ 2, 5, 25 })]
        public void CorpFlightBookings(int[] assert, int n, params int[][] bookings)
        {
            var result = _solution.CorpFlightBookings(bookings, n);

            Assert.Equal(result, assert);

        }
    }
}
