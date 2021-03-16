/*
 * @lc app=leetcode.cn id=51 lang=csharp
 *
 * [51] N皇后
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Text;

public partial class Solution {
    public IList<IList<string>> SolveNQueens(int n)
    {
        return SolveNQueens_Backtracking(n);
    }

    public IList<IList<string>> SolveNQueens_Backtracking(int n)
    {
        HashSet<int> cols = new HashSet<int>();
        HashSet<int> pie = new HashSet<int>();
        HashSet<int> na = new HashSet<int>();
        IList<IList<string>> result = new List<IList<string>>();
        DFS(cols, pie, na, result, n, 0, new int[n]);
        return result;
    }

    private void DFS(HashSet<int> cols, HashSet<int> pie, HashSet<int> na, IList<IList<string>> result, int n, int row, int[] currentState)
    {
        if (row >= n)
        {
            result.Add(PrintBoard(currentState));
            return;
        }
            
        for (int col = 0; col < n; col++)
        {
            if(cols.Contains(col) || pie.Contains(row + col) || na.Contains(row - col)) continue;

            cols.Add(col);
            pie.Add(row + col);
            na.Add(row - col);

            currentState[row] = col;
            DFS(cols, pie, na, result, n, row + 1, currentState);

            cols.Remove(col);
            pie.Remove(row + col);
            na.Remove(row - col);
        }
    }

    private IList<string> PrintBoard(int[] board)
    {
        IList<string> tmpRows = new List<string>();
        for(int row = 0; row < board.Length; row++)
        {
            int n = board[row];
            StringBuilder sb = new StringBuilder(board.Length);
            sb.Append('.', board.Length);
            sb.Replace('.', 'Q', n, 1);
            tmpRows.Add(sb.ToString());
        }

        return tmpRows;
    }
}
// @lc code=end

