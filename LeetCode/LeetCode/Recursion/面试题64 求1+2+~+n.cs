using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Recursion
    {
        public static int SumNums(int n)
        {
            int sum = n;
            bool r = n > 0 && (sum+=SumNums(--n)) >0;
            return sum;
        }
    }
}
