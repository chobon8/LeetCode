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

        int step = int.MaxValue;

        MinMutationDFS(start, 0, banks, visited, (gene, level) =>
        {
            if (gene.Equals(end)) step = Math.Min(level, step);
        });
        return step == int.MaxValue ? -1 : step;
    }

    private void MinMutationDFS(string current, int step, HashSet<string> banks,HashSet<string> visited, Action<string,int> process)
    {
        if(visited.Contains(current)) return;

        process(current, step);

        foreach(var bank in banks)
        {
            int diff = 0;
            for (int i = 0; i < bank.Length; i++)
            {
                if (bank[i] != current[i])
                {
                    if (++diff > 1) break;
                }
            }

            if (diff == 1)
            {
                visited.Add(current);
                MinMutationDFS(bank, step + 1, banks, visited, process);
                visited.Remove(current);
            }
        }
    }
}
// @lc code=end

