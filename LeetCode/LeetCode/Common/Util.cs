using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Common
{
    public class Util
    {
        public static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
