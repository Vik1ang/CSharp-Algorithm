using System;

namespace Leetcode.Solution.q5
{
    internal class Solution
    {
        public string LongestPalindrome(string s)
        {
            int max = 0;
            int start = 0;
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(i);

                int len = Math.Max(palindrome(s, i, i), palindrome(s, i, i + 1));

                if (len > max)
                {
                    max = len;
                    start =  i - (max + 1) / 2 + 1;
                }
            }


            return s.Substring(start, max);
        }

        private int palindrome(string s, int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                l--;
                r++;
            }

            return r - l - 1;
        }
    }
}
