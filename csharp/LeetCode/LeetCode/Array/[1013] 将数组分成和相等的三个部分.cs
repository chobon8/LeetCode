using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Array
    {
        public static bool CanThreePartsEqualSum(int[] A)
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
            }

            if (sum % 3 != 0) return false;
            int avg = sum / 3;
            int l = 0, r = A.Length - 1;
            int sum1 = A[l++], sum2 = A[r--];
            while (l < r)
            {
                if (sum1 != avg)
                    sum1 += A[l++];
                if (sum2 != avg)
                    sum2 += A[r--];
                if (sum1 == avg && sum2 == avg && r >= l)
                    return true;
            }
            return false;
        }
    }
}
