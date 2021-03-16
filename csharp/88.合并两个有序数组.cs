using System;
/*
 * @lc app=leetcode.cn id=88 lang=csharp
 *
 * [88] 合并两个有序数组
 */

// @lc code=start
public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int length = m + n -1;
        int l = m-1;
        int r = n-1;
        while (l >= 0 || r >=0)
        {
            if(l < 0)
            {
                nums1[length--] = nums2[r--];
            }
            else if(r < 0)
            {
                nums1[length--] = nums1[l--];
            }
            else if (nums1[l] > nums2[r])
            {
                nums1[length--] = nums1[l--];
            }
            else
            {
                nums1[length--] = nums2[r--];
            }
        }
    }
}
// @lc code=end

