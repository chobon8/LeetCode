/*
 * @lc app=leetcode.cn id=22 lang=csharp
 *
 * [22] 括号生成
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public IList<string> GenerateParenthesis(int n)
    {
        return GenerateParenthesis_DFS(n);
    }

    public IList<string> GenerateParenthesis_DFS(int n)
    {
        IList<string> result = new List<string>();

        GenerateParenthesisDFS(n, n, str=>result.Add(str));

        return result;
    }

    private void GenerateParenthesisDFS(int left,int right,Action<string> process, string str = "")
    {
        if (left == 0 && right == 0)
        {
            process(str);
            return;
        }

        if(left > 0)
        {
            str = str + '(';
            GenerateParenthesisDFS(left - 1, right, process, str);
            str = str.Remove(str.Length - 1);
        }

        if (right > 0)
        {
            str = str +')';
            GenerateParenthesisDFS(left, right-1, process, str);
            str.Remove(str.Length - 1);
        }
    }
}
// @lc code=end

