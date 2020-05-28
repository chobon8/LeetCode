/*
 * @lc app=leetcode.cn id=50 lang=csharp
 *
 * [50] Pow(x, n)
 */

// @lc code=start
public partial class Solution {
    public double MyPow(double x, int n)
    {
        return MyPow_BackTracking(x, n);
    }

    public double MyPow_BackTracking(double x, int n)
    {
        if (n == 0) return 1.0d;

        if (n < 0) 
        {
            n = -n;
            x = 1/x;
        }
        double half = MyPow_BackTracking(x, n / 2);

        return n % 2 == 0 ? half * half : half * half * x;
    }

    public double MyPow_BinarySearch(double x, int n)
    {
        return 0;
    }
}
// @lc code=end

