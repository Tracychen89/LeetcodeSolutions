using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDigital
{
   

    public class Solution
    {
        public int MyAddDigits(int num)
        {
            if (num < 10)
                return num;
            else
            {
                string s = num.ToString();
                int len = s.Length;
                int i = 0;
                int result = 0;
                for (i = 0; i < len; i++)
                {
                    int a = num % 10;
                    result += a;
                    num /= 10;
                }
                return AddDigits(result);
            }
        }

        public int AddDigits(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result += num % 10;
                if (result >= 10)
                {
                    result -= 9;
                }
                num /= 10;
            }
            return result;
        }

    }
}
