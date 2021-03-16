/*
 * @lc app=leetcode.cn id=820 lang=csharp
 *
 * [820] 单词的压缩编码
 */

// @lc code=start
public class Solution {
    public int MinimumLengthEncoding(string[] words) {
        HashSet<string> goods = new HashSet<string>(words);
        foreach(var word in words)
        {
            for(int i = 1; i < word.Length; i++)
            {
                goods.Remove(word.Substring(i));
            }
        }
        int ans = 0;
        foreach(var good in goods)
        {
            ans += good.Length + 1;
        }
        return ans;
    }
}
// @lc code=end

