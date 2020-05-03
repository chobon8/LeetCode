/*
 * @lc app=leetcode.cn id=3 lang=csharp
 *
 * [3] 无重复字符的最长子串
 */

// @lc code=start

using System;

public partial class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        return LengthOfLongestSubstring_SW(s);
    }

    public int LengthOfLongestSubstring_SW(string s)
    {
        int[] index = new int[128];
        int max = 0;
        int left = 0;
        for (int right = 0; right < s.Length; right++)
        {
            left = Math.Max(index[s[right]], left);

            max = Math.Max(max, right - left + 1);
            index[s[right]] = right + 1;
        }
        return max;
    }
}
// @lc code=end

