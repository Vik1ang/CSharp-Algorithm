using System;

namespace Leetcode.Solution.q4
{
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int n = nums1.Length;
            int m = nums2.Length;
            int left = (n + m + 1) / 2;
            int right = (n + m + 2) / 2;

            return (GetKth(nums1, 0, n - 1, nums2, 0, m - 1, left) + GetKth(nums1, 0, n - 1, nums2, 0, m - 1, right)) *
                   0.5;
        }

        private int GetKth(int[] nums1, int start1, int end1, int[] nums2, int start2, int end2, int k)
        {
            int len1 = end1 - start1 + 1;
            int len2 = end2 - start2 + 1;
            //让 len1 的长度小于 len2，这样就能保证如果有数组空了，一定是 len1 
            if (len1 > len2) return GetKth(nums2, start2, end2, nums1, start1, end1, k);
            if (len1 == 0) return nums2[start2 + k - 1];

            if (k == 1) return Math.Min(nums1[start1], nums2[start2]);

            int i = start1 + Math.Min(len1, k / 2) - 1;
            int j = start2 + Math.Min(len2, k / 2) - 1;

            if (nums1[i] > nums2[j])
            {
                return GetKth(nums1, start1, end1, nums2, j + 1, end2, k - (j - start2 + 1));
            }
            else
            {
                return GetKth(nums1, i + 1, end1, nums2, start2, end2, k - (i - start1 + 1));
            }
        }
    }
}