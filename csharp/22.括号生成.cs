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
        return GenerateParenthesis_BFS(n);
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

        if (right > 0 && right > left)
        {
            str = str +')';
            GenerateParenthesisDFS(left, right-1, process, str);
            str.Remove(str.Length - 1);
        }
    }

    public IList<string> GenerateParenthesis_BFS(int n)
    {
        IList<string> result = new List<string>();

        IList<Tuple<string, int, int>> queue = new List<Tuple<string, int, int>>();
        queue.Add(new Tuple<string, int, int>("(", n - 1, n));

        while (queue.Any())
        {
            IList<Tuple<string, int, int>> node = new List<Tuple<string, int, int>>();
            foreach (var tupe in queue)
            {
                var temp = tupe.Item1;
                var left = tupe.Item2;
                var right = tupe.Item3;
                if (left > 0)
                {
                    temp = tupe.Item1 + "(";
                    node.Add(new Tuple<string, int, int>(temp, left - 1, right));
                }

                if (right > 0 && right > left)
                {
                    temp = tupe.Item1 + ")";
                    node.Add(new Tuple<string, int, int>(temp, left, right - 1));
                }

                if (right == 0 && left == 0) result.Add(temp);
            }

            queue = node;
        }

        return result;
    }

    public IList<string> GenerateParenthesis_DynamicProgramming(int n)
    {
        throw new NotImplementedException();
    }
}
// @lc code=end

