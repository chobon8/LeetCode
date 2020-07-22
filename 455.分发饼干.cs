/*
 * @lc app=leetcode.cn id=455 lang=csharp
 *
 * [455] 分发饼干
 */

// @lc code=start
public partial class Solution {
    public int FindContentChildren(int[] g, int[] s)
    {
        return FindContentChildren_Greedy(g, s);
    }

    public int FindContentChildren_Greedy(int[] g, int[] s)
    {
        System.Array.Sort(g);
        System.Array.Sort(s);
        int i = 0;
        int j = 0;
        int res = 0;
        while (i < g.Length && j < s.Length)
        {
            if (s[j] >= g[i])
            {
                res++;
                i++;
            }
            j++;
        }

        return res;
    }
}
// @lc code=end

