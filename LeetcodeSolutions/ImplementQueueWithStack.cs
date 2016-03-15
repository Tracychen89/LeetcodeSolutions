using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
   
        
    public class Queue {
    
    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();
    int peek;
    // Push element x to the back of queue.
    public void Push(int x) 
    {
        
        if (s1.Count == 0)
        {
            peek = x;
        }
        s1.Push(x);
        
    }

    // Removes the element from front of queue.
    public void Pop()
    {

        while (s1.Count != 0)
        {
            s2.Push(s1.Pop());
        }
        s2.Pop();

        if (s2.Count != 0)
        {
            peek = s2.Peek();


            while (s2.Count != 0)
            {
                s1.Push(s2.Pop());
            }



        }
    }

    // Get the front element.
    public int Peek() {
       
        return peek;
        
    }

    // Return whether the queue is empty.
    public bool Empty() {
        
        return s1.Count == 0;
        
    }
}
    }
   

