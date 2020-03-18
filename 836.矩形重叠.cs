/*
 * @lc app=leetcode.cn id=836 lang=csharp
 *
 * [836] 矩形重叠
 */

// @lc code=start
public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
        if(Math.Min(rec1[2], rec2[2]) > Math.Max(rec1[0], rec2[0]) &&
            Math.Min(rec1[3], rec2[3]) > Math.Max(rec1[1], rec2[1]))
            return true;
        return false;
    }
}
// @lc code=end

