using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LeetCode
{
    public partial class Array
    {
        public static int MajorityElement(int[] nums)
        {
            int? major = null;
            int count = 0;
            foreach (int num in nums)
            {
                if (count == 0)
                    major = num;
                count += num == major ? 1 : -1;
            }

            return major.Value;
        }
    }
}
