using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class String
    { 
        public static string CompressString(string S)
        {
            string result = string.Empty;

            char temp = default;
            int count = 0;

            foreach (char c in S)
            {
                if (temp == default) temp = c;

                if (c.Equals(temp))
                {
                    count++;
                }
                else
                {
                    result += temp + $"{count}";
                    temp = c;
                    count = 1;
                }
            }

            result += temp + $"{count}";

            if (result.Length > S.Length) return S;

            return result;
        }
    }
}
