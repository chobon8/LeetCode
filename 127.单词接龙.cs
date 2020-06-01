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
        if (!wordList.Contains(endWord)) return 0;

        Queue<string> head = new Queue<string>();
        Queue<string> tail = new Queue<string>();

        head.Enqueue(beginWord);
        tail.Enqueue(endWord);

        HashSet<string> dict = new HashSet<string>(wordList);

        HashSet<string> visited = new HashSet<string>();

        int step = 1;

        while (head.Any() && tail.Any())
        {
            Queue<string> temp = new Queue<string>();

            if (head.Count > tail.Count)
            {
                var queue = head;
                head = tail;
                tail = queue;
            }

            foreach (var current in head)
            {

                char[] chs = current.ToCharArray();

                for (int i = 0; i < current.Length; i++)
                {
                    char old = chs[i];
                    for (int j = 0; j <= 26; j++)
                    {
                        char c = (char) (97 + j);

                        if (old == c) continue;

                        chs[i] = c;

                        string target = string.Concat(chs);

                        if (tail.Contains(target)) 
                            return step + 1;

                        if (!visited.Contains(target) && dict.Contains(target))
                        {

                            temp.Enqueue(target);
                            visited.Add(target);
                        }
                    }
                    chs[i] = old;
                }
            }

            head = temp;
            step++;
        }

        return 0;
    }

}
// @lc code=end

