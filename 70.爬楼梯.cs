/*
 * @lc app=leetcode.cn id=70 lang=csharp
 *
 * [70] 爬楼梯
 */

// @lc code=start

using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public int ClimbStairs(int n)
    {
        return ClimbStarirs_DP(n);
    }

    public int ClimbStarirs_DP(int n)
    {
        if(n == 1) return 1;
        int[] dp = Enumerable.Repeat(0, n).ToArray();
        dp[0] = 1;
        dp[1] = 2;
        for (int i = 2; i < n; i++)
        {
            dp[i] = dp[i - 2] + dp[i - 1];
        }

        return dp[n - 1];
    }
}
// @lc code=end

