/*
 * @lc app=leetcode.cn id=5 lang=csharp
 *
 * [5] 最长回文子串
 */

// @lc code=start
public class Solution {
    public string LongestPalindrome(string s) {
bool[,] dp = new bool[s.Length,s.Length] ;
            int a = 0, b = 0,max=0,start=0;
            for(int i = 0; i < s.Length; i++)
            {
                dp[i,i] = true;
                a = i - 1;
                b = i + 1;
                while(a>=0&&b<s.Length)
                {
                    dp[a,b] = (dp[a + 1,b-1] &&s[a] == s[b]);
                    a -= 1;
                    b += 1;
                }
                
            }
            for(int i=0;i<s.Length-1;i++)
            {
                dp[i,i + 1] = (s[i] == s[i + 1]);
                a = i - 1;
                b = i + 2;
                while (a >= 0 && b < s.Length)
                {
                    dp[a,b] = (dp[a + 1,b - 1] && s[a] == s[b]);
                    a -= 1;
                    b += 1;
                   
                }
            }
            
            for(int i=0;i<s.Length;i++)
            {
                for (int j=i+1;j<s.Length;j++ )
                {
                    if (dp[i,j])
                    {
                        if(max<j-i)
                        {
                            max = j - i;
                            start = i;
                        }
                    }
                }
            }
            return s.Substring(start,max+1);
    }
}
// @lc code=end

