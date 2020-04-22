using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Array
    {
        public static string GcdOfStrings(string str1, string str2)
        {
            if (str1 + str2 != str2 + str1) return "";
            int Gcd(int a, int b) => b == 0 ? a : Gcd(b, a % b);
            return str1.Substring(0, Gcd(str1.Length, str2.Length));
        }

        //public static string GcdOfStrings(string str1, string str2)
        //{
        //    int index = 0;
        //    while (index < str1.Length && index < str2.Length)
        //    {
        //        if (str1[index] != str2[index])
        //            break;
        //        index++;
        //    }

        //    string temp = str1.Substring(0, index);

        //    while (!string.IsNullOrEmpty(str1.Replace(temp, "")) || !string.IsNullOrEmpty(str2.Replace(temp,"")))
        //    {
        //        temp = str1.Substring(0, --index);
        //        if (index == 0)
        //            return "";
        //    }

        //    return temp;
        //}
    }
}
