using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseBits
{
    public class Solution
    {
        public uint reverseBits(uint n) {
        
        
        
        string s = Convert.ToString(n, 2);
        Char[] arr = s.ToCharArray();
        Stack<char> st = new Stack<char>();
        foreach(Char c in arr)
        {
            st.Push(c);
        }
        
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = st.Pop();
        }
        s = new string(arr);
        float res = Convert.ToUInt32(s, 16);
        uint result = 0;
        if (res > uint.MaxValue)
            return 0;
        else
            return result = Convert.ToUInt32(s, 16);
    }
    }
   
}
