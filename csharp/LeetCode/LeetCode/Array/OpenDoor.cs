using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Array
    {
        public static int[] OpenDoor(int personCount,int doorCount)
        {
            int[] doors = new int[doorCount];
            for (int i = 1; i <= personCount; i++)
            {
                int start = i-1;
                while (start < doorCount)
                {
                    if (i % 2 == 0)
                        doors[start] = doors[start] == 1 ? 0 : 1;
                    else
                        doors[start] = 1;
                    
                    
                    start += i;
                }
            }

            return doors;
        }
    }
}
