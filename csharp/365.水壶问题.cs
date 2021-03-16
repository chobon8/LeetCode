/*
 * @lc app=leetcode.cn id=365 lang=csharp
 *
 * [365] 水壶问题
 */

// @lc code=start
public class Solution {
    public bool CanMeasureWater(int x, int y, int z) {
        if(z == 0 || z == y || z == x) return true;
        if (x + y < z) return false;
        int big = Math.Max(x, y);//大
        int small = x + y - big;//小
        if (small == 0) return big == z;//x，y相等 满足必须z也相等
        //辗转相除
        while (big % small != 0) 
        {
            int temp = small;
            small = big % small;
            big = temp;
        }
        return z % small == 0;
    }
}
// @lc code=end

