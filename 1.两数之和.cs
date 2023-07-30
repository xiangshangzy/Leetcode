/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
            Dictionary<int, int> m = new ();
            for (int i = 0; i < nums.Length ; i++)
            {
                if (m.ContainsKey(target-nums[i]))
                {
                    return new[] { m[target - nums[i]],i };
                }
                m[nums[i]] = i;
            }
            return new[] { 0, 0 };
    }
}
// @lc code=end

