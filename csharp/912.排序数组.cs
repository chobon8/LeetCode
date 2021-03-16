/*
 * @lc app=leetcode.cn id=912 lang=csharp
 *
 * [912] 排序数组
 */

// @lc code=start
public class Solution {    
    public int[] SortArray(int[] nums) {
        int[] arr  = new int[100001];
        for(int i = 0;i<nums.Length;i++){
            arr[nums[i]+50000]++;
        }
        int j = 0;
        for(int i = 0;i<arr.Length;i++){
            while(arr[i]!=0){
                nums[j] = i-50000;
                j++;
                arr[i]--;
            }
        }
        return nums;
    }
}
// @lc code=end

