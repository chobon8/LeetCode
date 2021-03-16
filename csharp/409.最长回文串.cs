/*
 * @lc app=leetcode.cn id=409 lang=csharp
 *
 * [409] 最长回文串
 */

// @lc code=start
public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        int sum = 0;
        bool hasOdd = false;
        foreach(var c in s)
        {
            if(dict.ContainsKey(c))
            {
                dict[c]++;
            }
            else
            {
                dict[c] = 1;
            }
        }

        foreach(var val in dict.Values)
        {
            if(!hasOdd && val%2>0)
            {
                sum++;
                hasOdd = true;
            }

            if(val/2 > 0)
            {
                sum += (val/2) * 2;
            }
        }
        return sum;
    }
}
// @lc code=end

