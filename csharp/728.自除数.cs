/*
 * @lc app=leetcode.cn id=728 lang=csharp
 *
 * [728] 自除数
 */

// @lc code=start

using System.Collections.Generic;

public partial class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        IList<int> result = new List<int>();
        while(left <= right)
        {
            bool isDivisor = true;
            int dividend = left;
            while(dividend > 0 && isDivisor)
            {
                if(dividend % 10 > 0)
                {
                    int r = dividend % 10;
                    dividend = dividend / 10;
                    if (left % r > 0) 
                    {
                        isDivisor = false;
                    }
                    
                }
                else
                {
                    isDivisor = false;
                }
            }
            if(isDivisor)
                result.Add(left);
            left++;
        }

        return result;
    }
}
// @lc code=end

