using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Math
    {
        public static int Reverse(int x)
        {
            long lx = x;
            if (System.Math.Abs(lx) < 10) return x;
            long r = lx % 10;

            long sum = 0;
            if (r != 0)
                sum += r * 10;
            lx = lx / 10;
            while (System.Math.Abs(lx/10) > 0)
            {
                r = lx % 10;
                sum = (sum + r) * 10;
                if (int.MaxValue < sum || int.MinValue > sum) return 0;
                lx = lx / 10;
            }

            sum += lx;
            return (int) sum;
        }
    }
}
