/*
 * @lc app=leetcode.cn id=127 lang=csharp
 *
 * [127] 单词接龙
 */

// @lc code=start

using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        return LadderLength_BFS(beginWord, endWord, wordList);
    }

    public int LadderLength_BFS(string beginWord, string endWord, IList<string> wordList)
    {
        while (wordList.Any())
        {
            foreach (var word in wordList)
            {
                foreach (var VARIABLE in word)
                {
                    
                }
            }
        }
    }
}
// @lc code=end

