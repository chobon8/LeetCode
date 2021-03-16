/*
 * @lc app=leetcode.cn id=1109 lang=csharp
 *
 * [1109] 航班预订统计
 */

// @lc code=start

using System.Collections.Generic;
using System.Linq;

public partial class Solution {
    public int[] CorpFlightBookings(int[][] bookings, int n)
    {
        int[] flight = new int[n];

        foreach (var booking in bookings)
        {
            flight[booking[0]-1] += booking[2];

            if (booking[1] < n)
                flight[booking[1]] -= booking[2];
        }

        for (int i = 1; i < n; i++)
        {
            flight[i] += flight[i - 1];
        }

        return flight;
    }
}
// @lc code=end

