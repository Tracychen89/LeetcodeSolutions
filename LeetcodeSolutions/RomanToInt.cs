using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInt
{
    public class Solution {
    public int RomanToInt(string s) {
        Dictionary <char, int> map = new Dictionary<char, int>{ {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}};



        int result = 0;
        int pre = 0;
        int cur = 0;
        foreach (char c in s)
        {
            cur = map[c];
            result += cur;
            if (pre != 0 && pre < cur)
            {
                result -= 2 * pre;
            }              
            pre = cur;
        }
        return result;
        
    }
}
   
}
