/*
 * @lc app=leetcode.cn id=994 lang=csharp
 *
 * [994] 腐烂的橘子
 */

// @lc code=start
public class Solution {
    public int OrangesRotting(int[][] grid) {
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

            var decays = new List<string>(decayNew);

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
// @lc code=end

