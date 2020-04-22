using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Array
    {
        public static int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            for (int i = 0; i < prices.Length; i++)
            {
                while (stack.Count != 0 && stack.Peek() > prices[i])
                {
                    maxProfit = System.Math.Max(maxProfit, stack.Pop() - stack.Peek());
                }
                stack.Push(prices[i]);
            }

            return maxProfit;
        }

        /// <summary>
        /// 一次遍历
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit1(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                    minPrice = prices[i];
                maxProfit = System.Math.Max(maxProfit, prices[i] - minPrice);
            }
            return maxProfit;
        }
    }
}
