namespace Leetcode.Solution.q8
{
    public class Solution
    {
        public int MyAtoi(string s)
        {
            if (s == null)
            {
                return 0;
            }

            int len = s.Length;
            var chars = s.ToCharArray();

            int index = 0;
            while (index < len && chars[index] == ' ')
            {
                index++;
            }
            if (index == len)
            {
                return 0;
            }

            var sign = 1;
            if (chars[index] == '+')
            {
                index++;
            }
            else if (chars[index] == '-')
            {
                sign = -1;
                index++;
            }

            var res = 0;
            const int max = int.MaxValue / 10;
            const int min = int.MinValue / 10;
            while (index < len)
            {
                var temp = chars[index];
                if (temp > '9' || temp < '0')
                {
                    break;
                }

                if (res > max || (res == max && int.MaxValue % 10 < (temp - '0')))
                {
                    return int.MaxValue;
                }

                if (res < min || (res == min && -(int.MinValue % 10) < (temp - '0')))
                {
                    return int.MinValue;
                }

                res = res * 10 + (temp - '0') * sign;
                index++;
            }

            return res;
        }
    }
}