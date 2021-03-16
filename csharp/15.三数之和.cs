/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums);
        int l,r,sum;
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0)
                break;
            if (i > 0 && nums[i] == nums[i - 1])
                continue;
            l = i + 1;
            r = nums.Length - 1;
            while (l < r)
            {
                sum = nums[i] + nums[l] + nums[r];
                if (sum > 0)
                {
                    while (l<r && nums[r] == nums[r-1]) r--;
                    r--;
                }
                else if (sum < 0)
                {
                    while (l<r && nums[l] == nums[l+1]) l++;
                    l++;
                }
                else
                {
                    result.Add(new List<int> { nums[i], nums[l], nums[r] });
                    while (l<r && nums[l] == nums[l+1]) l++;
                    while (l<r && nums[r] == nums[r-1]) r--;
                    l++;
                    r--;
                }
            }
        }
        return result;
    }
}
// @lc code=end

