/*
 * @lc app=leetcode.cn id=122 lang=csharp
 *
 * [122] 买卖股票的最佳时机 II
 */

// @lc code=start
public partial class Solution {
    public int MaxProfitII(int[] prices)
    {
        return MaxProfitII_Greedy(prices);
    }

    public int MaxProfitII_Greedy(int[] prices)
    {
        int sum = 0;
        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1]) sum += prices[i] - prices[i - 1];
        }
        return sum;
    }
}
// @lc code=end

