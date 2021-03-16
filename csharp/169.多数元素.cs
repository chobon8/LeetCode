/*
 * @lc app=leetcode.cn id=169 lang=csharp
 *
 * [169] 多数元素
 */

// @lc code=start
public class Solution {
    public int MajorityElement(int[] nums) {
        int? major = null;
        int count = 0;
        foreach (int num in nums)
        {
            if (count == 0)
                major = num;
            count += num == major ? 1 : -1;
        }

        return major.Value;
    }
}
// @lc code=end

