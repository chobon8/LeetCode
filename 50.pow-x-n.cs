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
        if (x == 0.0d) return 0.0d;
        if (n == 0) return 1.0d;
        long b = n;
        if (n < 0)
        {
            b = -1 * b;
            x = 1 / x;
        }
        double half = MyPow_BackTracking(x, (int)(b / 2));

        return n % 2 == 0 ? half * half : half * half * x;
    }

    public double MyPow_BinarySearch(double x, int n)
    {
        if(x == 0.0d) return 0.0d;
        long b = n;
        double res = 1.0d;
        if(b < 0)
        {
            x = 1/x;
            b = -b;
        }
        while(b > 0)
        {
            if((b & 1) == 1) res *= x; 
            x *= x;
            b >>= 1;
        }
        return res;
    }
}
// @lc code=end

