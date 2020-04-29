using System;
using Xunit;

namespace LeetCodeTests
{
    public class UnitTestBase
    {

        protected readonly Solution _solution;

        protected UnitTestBase()
        {
            _solution = Activator.CreateInstance<Solution>();
        }
    }
}
