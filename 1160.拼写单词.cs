/*
 * @lc app=leetcode.cn id=1160 lang=csharp
 *
 * [1160] 拼写单词
 */

// @lc code=start
public class Solution {
    public int CountCharacters(string[] words, string chars) {
        int sum = 0;
        int[] charArray = new int[128];
        foreach(var c in chars)
        {
            if(charArray[c] == default)
                charArray[c] = 1;
            else 
                charArray[c]++;
        }
        
        foreach(var word in words)
        {
            bool isSpell = true;
            int[] wordArray = new int[128];
            foreach(var c in word)
            {
                if(wordArray[c] == default)
                    wordArray[c] = 1;
                else
                    wordArray[c]++;
            }

            foreach(var c in word)
            {
                if(wordArray[c] > charArray[c])
                {
                    isSpell = false;
                    break;
                }
            }
            if(isSpell) sum += word.Length;
        }
        return sum;
    }
}
// @lc code=end

