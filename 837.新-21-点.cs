/*
 * @lc app=leetcode.cn id=837 lang=csharp
 *
 * [837] 新21点
 */

// @lc code=start
public class Solution {
    public double New21Game(int N, int K, int W) {
        double[] dp = new double[N + W -1];
        for(int k = 0; k < K; k++)
        {
            dp[k] = 1.0;
        }
        double S = Math.Min(N - K + 1, W);

    }
}
// @lc code=end

