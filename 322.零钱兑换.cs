/*
 * @lc app=leetcode.cn id=322 lang=csharp
 *
 * [322] 零钱兑换
 */

// @lc code=start
public partial class Solution {
    public int CoinChange(int[] coins, int amount)
    {
        return CoinChange_DP(coins, amount);
    }

    public int CoinChange_DP(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        System.Array.Fill(dp, amount + 1);
        dp[0] = 0;
        for (int i = 1; i < dp.Length; i++)
        {
            foreach (var coin in coins)
            {
                if(i < coin) continue;
                dp[i] = System.Math.Min(dp[i], 1 + dp[i - coin]);
            }
        }

        return dp[amount] == amount + 1 ? -1 : dp[amount];
    }
}
// @lc code=end

