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
        IList<string> queue = new List<string> {beginWord};

        HashSet<string> visited = new HashSet<string>();

        int step = 0;

        while (queue.Any())
        {
            step++;
            IList<string> nodes = new List<string>();

            foreach (var current in queue)
            {
                //wordList.Remove(current);
                foreach (var word in wordList)
                {
                    if(visited.Contains(word)) continue;
                    int diff = 0;
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] != current[i] && ++diff > 1) break;
                    }

                    if (diff == 1)
                    {
                        if (word.Equals(endWord)) return step + 1;
                        nodes.Add(word);
                        visited.Add(word);
                    }
                    
                }
                
            }

            queue = nodes;
        }

        return 0;
    }
}
// @lc code=end

