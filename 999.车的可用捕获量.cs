/*
 * @lc app=leetcode.cn id=999 lang=csharp
 *
 * [999] 车的可用捕获量
 */

// @lc code=start
public class Solution {
    public int NumRookCaptures(char[][] board) {
        int length = board.Length;
        int[] dx = {0,1,0,-1};
        int[] dy = {1,0,-1,0};
        int Rx = 0;
        int Ry = 0;
        for (int x = 0; x < length; x++)
        {
            for (int y = 0; y < length; y++)
            {
                if (board[x][y] == 'R')
                {
                    Rx = x;
                    Ry = y;
                    break;
                }
            }
        }

        int count = 0;
        for(int i = 0; i < 4; i++)
        {
            for(int step = 0; ;step++)
            {
                int tx = Rx + step * dx[i];
                int ty = Ry + step * dy[i];
                if (tx < 0 || tx >= length || ty < 0 || ty >= length || board[tx][ty] == 'B') break;
                if (board[tx][ty] == 'p') 
                {
                    count++;
                    break;
                }
            }
        }
        return count;
    }
}
// @lc code=end

