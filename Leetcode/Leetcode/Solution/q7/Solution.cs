namespace Leetcode.Solution.q7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            var res = 0;
            const int max = int.MaxValue / 10;
            const int min = int.MinValue / 10;

            while (x != 0)
            {
                int temp = x % 10;
                if (res > max || (res == max && temp > int.MaxValue % 10))
                {
                    return 0;
                }
                if (res < min || (res == min && temp < int.MinValue % 10))
                {
                    return 0;
                }

                res = res * 10 + temp;
                x /= 10;
            }

            return res;
        }
    }
}