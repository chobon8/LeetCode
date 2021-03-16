/*
 * @lc app=leetcode.cn id=1013 lang=csharp
 *
 * [1013] 将数组分成和相等的三个部分
 */

// @lc code=start
public class Solution {
    public bool CanThreePartsEqualSum(int[] A) {
        int len = A.Length;
        if(len < 3) return false;
        int sum = 0;
        for(int i = 0; i < len; i++)
        {
            sum += A[i];
        }
        if(sum % 3 != 0) return false;
        int avg = sum/3;
        int l = 0, r = len-1;
        int sum1 = A[l++],sum2 = A[r--];
        while(l<r)
        {
            if(sum1 != avg)
                sum1+=A[l++];
            if(sum2 != avg)
                sum2 += A[r--];
            if(sum1 == avg && sum2 == avg && r >= l)
                return true;
        }
        
        return false;
    }
}
// @lc code=end

