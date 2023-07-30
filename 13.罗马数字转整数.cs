/*
 * @lc app=leetcode.cn id=13 lang=csharp
 *
 * [13] 罗马数字转整数
 */

// @lc code=start
public class Solution {
    public int RomanToInt(string s) {
            int sum = 0;
            s = s.Replace("IV", "a");
            s = s.Replace("IX", "b");
            s = s.Replace("XL", "c");
            s = s.Replace("XC", "d");
            s = s.Replace("CD", "e");
            s = s.Replace("CM", "f");
            foreach (var c in s)
            {
                switch (c)
                {
                    case 'I': sum+= 1;break;
                    case 'V': sum += 5; break;
                    case 'X': sum += 10; break;
                    case 'L': sum += 50; break;
                    case 'C': sum += 100; break;
                    case 'D': sum += 500; break;
                    case 'M': sum += 1000; break;
                    case 'a': sum += 4; break;
                    case 'b': sum += 9; break;
                    case 'c': sum += 40; break;
                    case 'd': sum += 90; break;
                    case 'e': sum += 400; break;
                    case 'f': sum += 900; break;
                }
            }
            return sum;
    }
}
// @lc code=end

