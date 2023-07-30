/*
 * @lc app=leetcode.cn id=9 lang=csharp
 *
 * [9] 回文数
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
            if (x < 0)
            {
                return false;
            }
            int n = 0;
            int x2 = x;
            while (x2 > 0)
            {
                n++;
                x2 /= 10;
            }
            x2 = 0;
            for(int i = 0; i <n ; i++)
            {
                x2 += x%(int)Math.Pow(10, n-i)/(int)Math.Pow(10,n-i-1)*(int)Math.Pow(10,i);

            }
            return x2 == x;
    }
}
// @lc code=end

