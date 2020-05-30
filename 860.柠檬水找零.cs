/*
 * @lc app=leetcode.cn id=860 lang=csharp
 *
 * [860] 柠檬水找零
 */

// @lc code=start
public partial class Solution {
    public bool LemonadeChange(int[] bills)
    {
        return LemonadeChange_Greedy(bills);
    }

    public bool LemonadeChange_Greedy(int[] bills)
    {
        int five = 0;
        int ten = 0;

        foreach (var bill in bills)
        {
            if (bill == 5)
            {
                five++;
            }
            else if (bill == 10 && five > 0)
            {
                ten++;
                five--;
            }
            else if (ten > 0 && five > 0)
            {
                ten--;
                five--;
            }
            else if (ten == 0 && five > 2)
            {
                    five -= 3;
            }
            else
                return false;
        }
        return true;
    }
}
// @lc code=end

