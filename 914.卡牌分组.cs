/*
 * @lc app=leetcode.cn id=914 lang=csharp
 *
 * [914] 卡牌分组
 */

// @lc code=start
public class Solution {
    public bool HasGroupsSizeX(int[] deck) {
        int x = 0;
        int[] count = new int[10000];
        foreach(int c in deck)
        {
            count[c]++;
        }
        
        for(int i = 0; i < 10000; i++)
        {
            if(count[i] > 0)
            {
                if(x == 0) 
                {
                    x = count[i];
                }
                else
                {
                    x = Gcd(count[i],x);
                }
            }
        }
        return x >= 2;
    }

    private int Gcd(int x,int y)
    {
        return y == 0 ? x : Gcd(y, x%y);
    }
}
// @lc code=end

