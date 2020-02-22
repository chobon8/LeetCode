/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> dict = new Dictionary<int,int>(); 
        for(int i = 0;i<nums.Length;i++)
        {
            int complement = target - nums[i];
            if(dict.ContainsKey(complement))
            {
                return new int[]{dict[complement],i};
            }
            dict[nums[i]] = i;
        }
        return null;
    }
}
// @lc code=end

