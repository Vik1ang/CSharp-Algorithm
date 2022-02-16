using System.Collections.Generic;

namespace Leetcode.Solution.q1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {
                    return new int[] { dic[target - nums[i]], i };
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }

            return new int[] { 0, 0 };
        }
    }
}