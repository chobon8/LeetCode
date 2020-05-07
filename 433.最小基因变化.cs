/*
 * @lc app=leetcode.cn id=433 lang=csharp
 *
 * [433] 最小基因变化
 */

// @lc code=start

using System;
using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public int MinMutation(string start, string end, string[] bank)
    {
        return MinMutation_DFS(start, end, bank);
    }

    public int MinMutation_BFS(string start, string end, string[] bank)
    {
        List<char> card = new List<char>{'A','C','G','T'};

        HashSet<string> banks = new HashSet<string>(bank);

        List<string> queue = new List<string>{ start };

        banks.Remove(start);

        int level = 0;

        while (queue.Any())
        {
            level++;
            List<string> genes = new List<string>();
            foreach (var gene in queue)
            {
                for (int i = 0; i < gene.Length; i++)
                {
                    var geneTemp = gene.ToCharArray();
                    foreach (var c in card)
                    {
                        if (gene[i] != c)
                        {
                            geneTemp[i] = c;
                            var newGene = new string(geneTemp);
                            if (banks.Contains(newGene))
                            {
                                if (newGene.Equals(end))
                                    return level;
                                banks.Remove(newGene);
                                genes.Add(newGene);
                            }
                        }
                    }
                }
            }

            queue = genes;
        }

        return -1;
    }

    public int MinMutation_DFS(string start, string end, string[] bank)
    {
        HashSet<string> banks = new HashSet<string>(bank);

        HashSet<string> visited = new HashSet<string>();

        int step = 0;

        MinMutationDFS(start, end, gene=> visited.Contains(gene), gene =>
        {
            foreach (var bank in banks)
            {
                int diff = 0;
                for (int i = 0; i < bank.Length; i++)
                {

                    if (bank[i] != gene[i])
                    {
                        if(++diff > 1) break;
                    }
                    
                }

                if (diff == 1)
                {
                    if (bank == end)
                    {
                        return bank;
                    }

                    visited.Add(bank);
                }
            }

            //step = 0;
            return null;
        });
        return step == 0 ? -1 : step;
    }

    private void MinMutationDFS(string current,string end,Func<string,bool> isVisited,Func<string,string> process)
    {
        if (current == end || current == null) return;
        current = process(current);
        if (!isVisited(current))
        {
            MinMutationDFS(current, end, isVisited, process);
        }
    }
}
// @lc code=end

