/*
 * @lc app=leetcode.cn id=62 lang=csharp
 *
 * [62] 不同路径
 */

// @lc code=start

using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public int UniquePaths(int m, int n)
    {
        return UniquePaths_DP(m, n);
    }

    public int UniquePaths_DP(int m, int n)
    {
        int[] paths = new int[n];
        System.Array.Fill(paths, 1);
        for (int i = 1; i < m ; i++)
        {
            for (int j = 1; j < n; j++)
            {
                paths[j] += paths[j - 1];
            }
        }

        return paths[n - 1];
    }
}
// @lc code=end

