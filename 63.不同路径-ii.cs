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
        int width = obstacleGrid[0].Length;
        int[] paths = new int[width];
        paths[0] = 1;
        foreach (var row in obstacleGrid)
        {
            for (int j = 0; j < width; j++)
            {
                if (row[j] == 1)
                {
                    paths[j] = 0;
                }
                else if(j > 0)
                    paths[j] += paths[j - 1];

            }
        }

        return paths[width-1];
    }
}
// @lc code=end

