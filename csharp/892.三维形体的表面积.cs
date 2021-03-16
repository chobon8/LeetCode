/*
 * @lc app=leetcode.cn id=892 lang=csharp
 *
 * [892] 三维形体的表面积
 */

// @lc code=start
public class Solution {
    public int SurfaceArea(int[][] grid) {
        int area = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                int level = grid[i][j];
                if(level > 0)
                {
                    area += (level << 2) + 2;
                    area -= i > 0 ? Math.Min(grid[i-1][j],level) << 1 : 0;
                    area -= j > 0 ? Math.Min(grid[i][j-1],level) << 1 : 0;
                }
            }
        }
        return area;
    }
}
// @lc code=end

