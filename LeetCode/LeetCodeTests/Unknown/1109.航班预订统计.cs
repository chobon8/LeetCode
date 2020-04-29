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
        [AutoData]
        public void CorpFlightBookings()
        {
            int[][] bookings = new [3][3]{[1, 2, 4],[1, 2, 4],[1, 2, 4],[1, 2, 4],[1, 2, 4]};

            var result = _solution.CorpFlightBookings(bookings, n);

            Assert.
        }
    }
}
