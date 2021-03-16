/*
 * @lc app=leetcode.cn id=945 lang=csharp
 *
 * [945] 使数组唯一的最小增量
 */

// @lc code=start
public class Solution {
    public int MinIncrementForUnique(int[] A) {
        if(A.Length == 0) return 0;
        int opnum = 0;
        int min = int.MaxValue;
        int max = 0;
        foreach(var num in A)
        {
            if(num > max) max = num;
            if(num < min) min = num;
        }

        int[] countMap = new int[max + A.Length - min];
        foreach(var num in A)
        {
            countMap[num - min]++;
        }
        for(int num = min; num < countMap.Length; num++)
        {
            int del = countMap[num - min] - 1;
            if(del > 0)
            {
                countMap[num - min + 1] += del;
                opnum+=del;
            }
        }
        return opnum;
    }
}
// @lc code=end

