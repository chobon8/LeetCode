using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace LeetCodeTests.Unknown
{
    public class UnknownTest : UnitTestBase
    {
        [Fact]
        public void CorpFlightBookings()
        {
            int n = 5;

            int[][] bookings = {new[] { 1, 2, 10 }, new[] { 2, 3, 20 }, new[] { 2, 5, 25 }};

            var result = _solution.CorpFlightBookings(bookings, n);

            Assert.Equal(result,new []{ 10, 55, 45, 25, 25 });
        }
    }
}
