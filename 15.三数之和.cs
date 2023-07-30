/*
 * @lc app=leetcode.cn id=15 lang=csharp
 *
 * [15] 三数之和
 */

// @lc code=start
public class Solution {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<IList<int>> result = new ();
            List<int> list=new (), pre;
            for (int i = 0; i < nums.Length; i++) { 
            for(int j = i+1; j < nums.Length; j++) { 
                
            for(int k = j+1; k < nums.Length; k++) {
                        if (nums[i] + nums[j] + nums[k]==0)
                        {
                            pre = list;
                            list = new List<int> { nums[i], nums[j], nums[k] };
                            if (!list.SequenceEqual(pre))
                            { result.Add(list); }
                            
                            
                        }
                    
                    }
                }

            }
            return result;
        }
}
// @lc code=end

