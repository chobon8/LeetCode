/*
 * @lc app=leetcode.cn id=63 lang=csharp
 *
 * [63] 不同路径 II
 */

// @lc code=start
public partial class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        return UniquePathsWithObstacles_DP(obstacleGrid);
    }

    public int UniquePathsWithObstacles_DP(int[][] obstacleGrid)
    {
        int[] paths = new int[obstacleGrid[0].Length];
        System.Array.Fill(paths,1);
        for (int i = 1; i <= obstacleGrid.Length; i++)
        {
            for (int j = 1; j <= obstacleGrid[^i].Length; j++)
            {
                if (obstacleGrid[^i][^j] == 1)
                {
                    paths[^j] = 0;
                    continue;
                }

                if (j == 1)
                {
                    continue;
                }

                if (i == 1)
                    paths[^j] = paths[^(j - 1)];
                else
                    paths[^j] += paths[^(j - 1)];

            }
        }

        return paths[0];
    }
}
// @lc code=end

