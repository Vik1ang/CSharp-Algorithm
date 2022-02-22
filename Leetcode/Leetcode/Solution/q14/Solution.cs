namespace Leetcode.Solution.q14
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }

            for (var i = 0; i < strs[0].Length; ++i)
            {
                var c = strs[0][i];
                for (var j = 1; j < strs.Length; ++j)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                    {
                        return strs[0][..i];
                    }
                }
            }
            return strs[0];
        }
    }
}