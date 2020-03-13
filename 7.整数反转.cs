/*
 * @lc app=leetcode.cn id=7 lang=csharp
 *
 * [7] 整数反转
 */

// @lc code=start
public class Solution {
    public int Reverse(int x) {
        long lx = x;
        if(Math.Abs(lx) < 10) return x;
        long r = lx % 10;

        long sum = 0;
        if (r != 0)
            sum += r * 10;
        lx = lx / 10;
        while (Math.Abs(lx/10) > 0)
        {
            r = lx % 10;
            sum = (sum + r) * 10;
            if (int.MaxValue < sum || int.MinValue > sum) return 0;
            lx = lx / 10;
        }

        sum += lx;
        return (int) sum;
    }
}
// @lc code=end

