/*
 * @lc app=leetcode.cn id=300 lang=csharp
 *
 * [300] 最长上升子序列
 */

// @lc code=start
public class Solution {
    public int LengthOfLIS(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        int[] tails = new int[nums.Length];
        int max = 0;
        foreach (int num in nums)
        {
            int i = 0, j = max;
            while (i<j)
            {
                int m = (i + j) / 2;
                if (tails[m] < num)
                    i = m + 1;
                else
                    j = m;
            }
            tails[i] = num;
            if (max == j) max++;
        }
        return max;
    }
}
// @lc code=end

