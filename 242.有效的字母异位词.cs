/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public bool IsAnagram(string s, string t)
    {
        return IsAnagram_Sort(s, t);
    }

    public bool IsAnagram_Dictionary(string s, string t)
    {
        Dictionary<char, int> sDict = new Dictionary<char, int>();
        Dictionary<char, int> tDict = new Dictionary<char, int>();
        foreach (var s1 in s)
        {
            if (sDict.ContainsKey(s1))
            {
                sDict[s1]++;
            }
            else
            {
                sDict[s1] = 1;
            }
        }
        foreach (var t1 in t)
        {
            if (tDict.ContainsKey(t1))
            {
                tDict[t1]++;
            }
            else
            {
                tDict[t1] = 1;
            }
        }

        return !(sDict.Count != tDict.Count || sDict.Except(tDict).Any());
    }

    public bool IsAnagram_Sort(string s, string t)
    {
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();
        Array.Sort(sArray);
        Array.Sort(tArray);

        if (sArray.SequenceEqual(tArray))
            return true;
        return false;
    }
}
// @lc code=end

