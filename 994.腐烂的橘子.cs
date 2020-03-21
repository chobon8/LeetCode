/*
 * @lc app=leetcode.cn id=994 lang=csharp
 *
 * [994] 腐烂的橘子
 */

// @lc code=start
public class Solution {
    public int OrangesRotting(int[][] grid) {
        List<int> decayNew = new List<int>();
        int R = grid.Length;
        int C = grid[0].Length;
        int minute = 0;

        int[] dr = {-1,0,1,0};
        int[] dc = {0,-1,0,1};
        

        for (int r = 0; r < grid.Length; r++)
        {
            for (int c = 0; c < grid[r].Length; c++)
            {
                if(grid[r][c] == 2)
                {
                    int key = r * C + c;
                    decayNew.Add(key);
                }
            }
        }

        while (decayNew.Any())
        {
            var decays = new List<int>(decayNew);

            decayNew.Clear();

            foreach (var decay in decays)
            {
                int r = decay / C;
                int c = decay % C;
                for(int i = 0; i < 4; i++)
                {
                    int nr = r + dr[i];
                    int nc = c + dc[i];
                    if(nr >= 0 && nr < R && nc >=0 && nc < C && grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        int key = nr * C + nc;
                        decayNew.Add(key); 
                    }
                }
            }
            if(decayNew.Any()) minute++;
        }
        foreach(var row in grid)
        {
            foreach(var c in row)
            {
                if(c == 1) return -1;
            }
        }

        return minute;
    }
}
// @lc code=end

