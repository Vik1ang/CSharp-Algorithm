using System;
using System.Collections.Generic;

namespace Leetcode.Solution.q3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> window = new Dictionary<char, int>();

            int left = 0, right = 0;
            int res = 0;

            while (right < s.Length)
            {
                char c = s[right];
                right++;

                window[c] = window.GetValueOrDefault(c, 0) + 1;

                while (window[c] > 1)
                {
                    char d = s[left];
                    left++;

                    if (window.ContainsKey(d))
                    {
                        window[d]--;
                    }
                }

                res = Math.Max(res, right - left);
            }

            return res;
        }
    }
}
