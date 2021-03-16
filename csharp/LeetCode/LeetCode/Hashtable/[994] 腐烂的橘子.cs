using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Hashtable
    {
        public static int OrangesRotting(int[][] grid)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> decayNew = new List<int>();
            int R = grid.Length;
            int C = grid[0].Length;
            int minute = 0;

            int[] dr = { -1, 0, 1, 0 };
            int[] dc = { 0, -1, 0, 1 };


            for (int r = 0; r < grid.Length; r++)
            {
                for (int c = 0; c < grid[r].Length; c++)
                {
                    if (grid[r][c] == 2)
                    {
                        int key = r * C + c;
                        decayNew.Add(key);
                    }
                }
            }


            while (decayNew.Any())
            {
                var decays = new List<int>(decayNew);

                decayNew.Clear();

                foreach (var decay in decays)
                {
                    int r = decay / C;
                    int c = decay % C;
                    for (int i = 0; i < 4; i++)
                    {
                        int nr = r + dr[i];
                        int nc = c + dc[i];
                        if (nr >= 0 && nr < R && nc >= 0 && nc < C && grid[nr][nc] == 1)
                        {
                            grid[nr][nc] = 2;
                            decayNew.Add(nr * C + nc);
                        }
                    }
                }
                if(decayNew.Any()) minute++;
            }

            foreach (var row in grid)
            {
                foreach (var c in row)
                {
                    if (c == 1) return -1;
                }
            }
            return minute;
        }

        public static int OrangesRotting1(int[][] grid)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            int minute = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    string key = $"{i},{j}";
                    dict[key] = grid[i][j];
                }
            }

            List<string> decayNew = dict.Where(x => x.Value == 2).Select(x => x.Key).ToList();

            while (dict.ContainsValue(1))
            {
                minute++;
                if (decayNew.Count == 0)
                {
                    return -1;
                }

                var decays = decayNew.ToImmutableList();

                decayNew.Clear();

                foreach (var decay in decays)
                {
                    string[] site = decay.Split(',');
                    int i = int.Parse(site[0]);
                    int j = int.Parse(site[1]) ;
                    string up = $"{i},{j + 1}";
                    string down = $"{i},{j - 1}";
                    string left = $"{i - 1},{j}";
                    string right = $"{i + 1},{j}";
                    if (dict.ContainsKey(up) && dict[up] == 1)
                    {
                        decayNew.Add(up);
                    }

                    if (dict.ContainsKey(down) && dict[down] == 1)
                    {
                        decayNew.Add(down);
                    }

                    if (dict.ContainsKey(left) && dict[left] == 1)
                    {
                        decayNew.Add(left);
                    }

                    if (dict.ContainsKey(right) && dict[right] == 1)
                    {
                        decayNew.Add(right);
                    }
                }

                foreach (var decay in decayNew)
                {
                    dict[decay] = 2;
                }
            }

            return minute;
        }

    }
}
