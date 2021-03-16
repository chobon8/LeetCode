/*
 * @lc app=leetcode.cn id=33 lang=csharp
 *
 * [33] 搜索旋转排序数组
 */

// @lc code=start
public partial class Solution {
    public int Search(int[] nums, int target)
    {
        return Search_BinarySearch(nums, target);
    }

    public int Search_BinarySearch(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target) return mid;

            if (nums[mid] < target ^ nums[left] > target ^ nums[left] > nums[mid])
                left = mid + 1;
            else
                right = mid;
        }
        return -1;
    }
}
// @lc code=end

