/*
 * @lc app=leetcode.cn id=4 lang=csharp
 *
 * [4] 寻找两个正序数组的中位数
 */

// @lc code=start
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
            int m = nums1.Length;
            int n = nums2.Length;
            int k = m + n;
            int mid = (m + n) / 2+1;
            for(int i = 0; i < mid; i++)
            {
                if (i < m&&mid-i-2<n)
                {
                    if (( mid-i-2==-1||nums1[i] >= nums2[mid - i-2 ]) && ( mid-i-1==n||nums1[i] <= nums2[mid - i-1]))

                    {
                        if (k%2!=0)
                        return nums1[i];
                        else
                        {
                            if(i-1==-1)
                            {
                                return (double)(nums2[mid - i - 2] + nums1[i])/ 2;
                            }
                            else if(mid-i-2==-1)
                            {
                                return (double)(nums1[i-1] + nums1[i]) / 2;

                            }
                            else
                            {
                                return (double)(Math.Max(nums2[mid - i - 2], nums1[i - 1]) + nums1[i]) / 2;

                            }

                        }
                    }

                }
                if (i < n && mid - i - 2 < m)
                {
                    if ((mid - i - 2 == -1 || nums2[i] >= nums1[mid - i - 2]) && (mid - i - 1 == m || nums2[i] <= nums1[mid - i - 1]))

                    {
                        if (k % 2 != 0)
                            return nums2[i];
                        else
                        {
                            if (i - 1 == -1)
                            {
                                return (double)(nums1[mid - i - 2] + nums2[i]) / 2;
                            }
                            else if (mid - i - 2 == -1)
                            {
                                return (double)(nums2[i - 1] + nums2[i]) / 2;

                            }
                            else
                            {
                                return (double)(Math.Max(nums1[mid - i - 2], nums2[i - 1]) + nums2[i]) / 2;

                            }

                        }
                    }

                }

            }
            return 0;
    }
}
// @lc code=end

