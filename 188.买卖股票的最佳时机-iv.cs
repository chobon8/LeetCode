/*
 * @lc app=leetcode.cn id=188 lang=csharp
 *
 * [188] 买卖股票的最佳时机 IV
 */

// @lc code=start
using System;

public partial class Solution {
    public int MaxProfitIV(int k, int[] prices)
    {
        return MaxProfitIV_DP(k, prices);
    }

    public int MaxProfitIV_DP(int k, int[] prices)
    {
        if (prices.Length == 0) return 0;
        int[,] maxProfitDp = new int[prices.Length, k + 1];
        for (int j = 1; j <= k; j++)
        {
            int minPrice = prices[0];

            for (int i = 1; i < prices.Length; i++)
            {
                minPrice = Math.Min(prices[i] - maxProfitDp[i, j - 1], minPrice);
                maxProfitDp[i, j] = Math.Max(maxProfitDp[i - 1, j], prices[i] - minPrice);
            }
        }

        return maxProfitDp[prices.Length - 1, k];
    }
}
// @lc code=end

