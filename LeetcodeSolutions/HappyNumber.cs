using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumber
{

    public class Solution
    {
        public bool IsHappy(int n)
        {
            if (n < 1)
                return false;
            else
            {
                HashSet<int> h = new HashSet<int>();
                while (!h.Contains(n))
                {
                    h.Add(n);
                    int res = 0;
                    while (n > 0)
                    {
                        res += (n % 10) * (n % 10);
                        n = n / 10;
                    }
                    n = res;
                    
                    if (n == 1)
                        return true;
                }
                return false;
            }

        }
    }
   
}
