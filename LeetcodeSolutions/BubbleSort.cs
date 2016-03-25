using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {

       public int[] SortArray(int[] arr)
        {
            int temp;
            int len = arr.Length;
           for(int i = 0; i < len; i++)
           {
               for(int j = 1; j < len-1; j++)
               {
                   if(arr[j] > arr[j+1])
                   {
                       temp = arr[j];
                       arr[j] = arr[j+1];
                       arr[j + 1] = temp;        
                   }
               }
           }
           return arr;

        }
    }
   
}
