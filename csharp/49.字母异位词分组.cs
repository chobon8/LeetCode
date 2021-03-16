/*
 * @lc app=leetcode.cn id=49 lang=csharp
 *
 * [49] 字母异位词分组
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        return GroupAnagrams_Prime(strs);
    }

    /// <summary>
    /// 计数解法，26个字母数组，根据每个字符出现数量组成唯一key，例如：aabc-211，存入字典
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public IList<IList<string>> GroupAnagrams_Count(string[] strs)
    {
        Dictionary<string,IList<string>> dict = new Dictionary<string, IList<string>>();

        int[] count = new int[26];
        foreach (var str in strs)
        {
            Array.Fill(count, 0); 
            foreach (var c in str.ToCharArray())
            {
                count[c - 'a']++;
            }

            var key = string.Join("", count);
            
            if(dict.ContainsKey(key))
                dict[key].Add(str);
            else
                dict[key] = new List<string> { str };
        }

        return dict.Values.ToList();
    }

    /// <summary>
    /// 字符串排序解法，每个字符串排序，作为key，存入字典
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public IList<IList<string>> GroupAnagrams_Sort(string[] strs)
    {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();

        foreach (var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var key = string.Concat(charArray);

            if (dict.ContainsKey(key))
                dict[key].Add(str);
            else
                dict[key] = new List<string> { str };
        }

        return dict.Values.ToList();
    }

    /// <summary>
    /// 质数解法，根据算数基本定理，可以确定每个字符的唯一key，存入字典
    ///
    /// 小知识：算术基本定理，又称为正整数的唯一分解定理，即：每个大于1的自然数，要么本身就是质数，要么可以写为2个以上的质数的积，而且这些质因子按大小排列之后，写法仅有一种方式。
    /// </summary>
    /// <param name="strs"></param>
    /// <returns></returns>
    public IList<IList<string>> GroupAnagrams_Prime(string[] strs)
    {
        int[] primes =
            {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103};

        Dictionary<int, IList<string>> dict = new Dictionary<int, IList<string>>();

        foreach (var str in strs)
        {
            int key = 1;
            foreach (var s in str.ToCharArray())
            {
                key *= primes[s - 'a'];
            }

            if (dict.ContainsKey(key))
                dict[key].Add(str);
            else
                dict[key] = new List<string> {str};
        }

        return dict.Values.ToList();
    }
}
// @lc code=end

