/*
 * @lc app=leetcode.cn id=1103 lang=csharp
 *
 * [1103] 分糖果 II
 */

// @lc code=start
public class Solution {
    public int[] DistributeCandies(int candies, int num_people) {
        int[] result = new int[num_people];

        int num = 0;
        while (candies > 0)
        {
            int index = num % num_people;

            if (result[index] == default) result[index] = 0;

            if (candies > num)
            {
                candies -= ++num;
                
                result[index] += num;
            }
            else
            {
                result[index] += candies;
                break;
            }
        }

        return result;
    }
}
// @lc code=end

