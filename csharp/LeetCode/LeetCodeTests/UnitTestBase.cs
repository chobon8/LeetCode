using System;
using System.Collections.Generic;
using System.Linq;
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

    public class Comparer : IEqualityComparer<string[][]>
    {
        public bool Equals(string[][] x, string[][] y)
        {
            if (x == null || y == null) return false;

            foreach (var x1 in x)
            {
                bool isEqual = false;
                foreach (var y1 in y)
                {
                    if (x1.Length == y1.Length && !x1.Except(y1).Any())
                    {
                        isEqual = true;
                        break;
                    }
                }

                if (!isEqual) return false;
            }

            return true;
        }
        public int GetHashCode(string[][] obj)
        {
            throw new NotImplementedException();
        }
    }
}
