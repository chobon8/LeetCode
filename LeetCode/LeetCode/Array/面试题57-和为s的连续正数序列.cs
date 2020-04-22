using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Array
    {
        public static int[][] FindContinuousSequence(int target)
        {
            List<int[]> res = new List<int[]>();
            int left = 1;
            int right = 1;
            int sum = 1;
            while (left < target)
            {
                if (sum > target)
                {
                    sum -= left++;
                }
                else if (sum < target)
                {
                    sum += ++right;
                }
                else
                {
                    List<int> arr = new List<int>();
                    for (int i = left; i <= right; i++)
                    {
                        arr.Add(i);
                    }
                    res.Add(arr.ToArray());
                    sum -= left++;
                }
            }

            return res.ToArray();
        }
    }
}
