/*
 * @lc app=leetcode.cn id=121 lang=csharp
 *
 * [121] 买卖股票的最佳时机
 */

// @lc code=start
public partial class Solution {
    public int MaxProfit(int[] prices)
    {
        return MaxProfit_DP(prices);
    }

    public int MaxProfit_DP(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];
            maxProfit = System.Math.Max(maxProfit, prices[i] - minPrice);
        }
        return maxProfit;
    }
}
// @lc code=end

