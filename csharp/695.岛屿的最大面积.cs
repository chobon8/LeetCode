/*
 * @lc app=leetcode.cn id=695 lang=csharp
 *
 * [695] 岛屿的最大面积
 */

// @lc code=start
public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;
        for(int i = 0; i < grid.Length; i++)
        {
            for(int j = 0; j < grid[i].Length; j++)
            {
                if(grid[i][j] == 1)
                    max = Math.Max(DFS(grid,i,j),max);
            }
        }
        return max;
    }

    public int DFS(int[][] grid, int i, int j)
    {
        if(i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] == 0)
            return 0;
        grid[i][j] = 0;
        int count = 1;
        count += DFS(grid,i+1,j);
        count += DFS(grid,i-1,j);
        count += DFS(grid,i,j+1);
        count += DFS(grid,i,j-1);
        return count;
    }
}
// @lc code=end

