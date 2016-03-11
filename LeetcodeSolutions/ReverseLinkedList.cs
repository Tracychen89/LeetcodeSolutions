using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{
   
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {

            ListNode p = head;
            ListNode n = null;
            ListNode tmp = null;
            while (p != null)
            {
                tmp = p.next;
                p.next = n;
                n = p;
                p = tmp;
            }
            return n;


        }
    }



}
