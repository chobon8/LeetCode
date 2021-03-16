using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class BinarySearch
    {
        public static int SurfaceArea(int[][] grid)
        {
            int area = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    int level = grid[i][j];
                    if (level > 0)
                    {
                        area += (level << 2) + 2;
                        area -= i > 0 ? System.Math.Min(grid[i - 1][j], level) << 1 : 0;
                        area -= j > 0 ? System.Math.Min(grid[i][j - 1], level) << 1 : 0;
                    }
                }
            }

            return area;
        }
    }
}
