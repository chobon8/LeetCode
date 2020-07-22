using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class DynamicProgramming
    {
        public static int Massage(int[] nums)
        {
            //0:接单，1:不接单
            int[][] dp = new int[nums.Length][];
            for (int i = 0; i < nums.Length; i++)
            {
                dp[0][i] = nums[i];
                dp[1][i] = 1;
            }
            return 0;
        }
    }
}
