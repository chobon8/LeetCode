/*
 * @lc app=leetcode.cn id=1071 lang=csharp
 *
 * [1071] 字符串的最大公因子
 */

// @lc code=start
public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        int index = 0;
        while (index < str1.Length && index < str2.Length)
        {
            if (str1[index] != str2[index])
                break;
            index++;
        }

        if(index == 0) return "";

        string temp = str1.Substring(0, index);

        while (!string.IsNullOrEmpty(str1.Replace(temp, "")) || !string.IsNullOrEmpty(str2.Replace(temp,"")))
        {
            temp = str1.Substring(0, --index);
            if (index == 0)
                return "";
        }

        return temp;  
    }
}
// @lc code=end

