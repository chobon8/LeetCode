using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class DepthFirstSearch
    {
        public static int NumRookCaptures(char[][] board)
        {
            int length = board.Length;
            int Ri = 0;
            int Rj = 0;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (board[i][j] == 'R')
                    {
                        Ri = i;
                        Rj = j;
                        break;
                    }
                }
            }
            int left = Ri;
            int right = Ri;
            int up = Rj;
            int down = Rj;

            int count = 0;
            while (left >= 0 || right < length || up >= 0 || down < length)
            {
                if (left > 0)
                {
                    if (board[left][Rj] == 'p')
                    {
                        count++;
                        left = 0;
                    } else if (board[left][Rj] == 'B')
                    {
                        left = 0;
                    }
                    left--;
                }
                if (right < length)
                {
                    if (board[right][Rj] == 'p')
                    {
                        count++;
                        right = length;
                    }
                    else if (board[right][Rj] == 'B')
                    {
                        right = length;
                    }
                    right++;
                }
                if (up > 0)
                {
                    if (board[Ri][up] == 'p')
                    {
                        count++;
                        up = 0;
                    } 
                    else if (board[Ri][up] == 'B')
                    {
                        up = 0;
                    }
                    up--;
                }
                if (down < length)
                {
                    if (board[Ri][down] == 'p')
                    {
                        count++;
                        down = length;
                    }
                    else if (board[Ri][down] == 'B')
                    {
                        down = length;
                    }
                    down++;
                }
            }
            return count;
        }
    }
}
