/*
 * @lc app=leetcode.cn id=123 lang=csharp
 *
 * [123] 买卖股票的最佳时机 III
 */

// @lc code=start

using System;

public partial class Solution {
    public int MaxProfitIII(int[] prices)
    {
        return MaxProfitIII_DP(prices);
    }

    /// <summary>
    /// c(i,k)=c(i,k-1)+prices[j]-min(i~j)
    /// </summary>
    /// <param name="prices"></param>
    /// <returns></returns>
    public int MaxProfitIII_DP(int[] prices)
    {
        if (prices.Length == 0) return 0;
        int K = 2;
        int[,] maxProfitDp = new int[prices.Length, K+1];
        for (int k = 1; k <= K; k++)
        {
            int minPrice = prices[0];
            
            for (int i = 1; i < prices.Length; i++)
            {
                minPrice = Math.Min(prices[i] - maxProfitDp[i, k - 1], minPrice);
                maxProfitDp[i,k] = Math.Max(maxProfitDp[i-1,k], prices[i] - minPrice);
            }
        }

        return maxProfitDp[prices.Length - 1, K];
    }
}
// @lc code=end

