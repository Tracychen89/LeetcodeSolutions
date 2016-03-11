using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromSortedlist
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {

            if (head != null && head.next != null)
            {
                ListNode current = head;

                Queue<int> q = new Queue<int>();
                q.Enqueue(head.val);
                while (current.next != null)
                {
                    if (q.Contains(current.next.val))
                    {
                        current = current.next;
                    }
                    else
                        q.Enqueue(current.next.val);
                    current = current.next;
                }


                q.Dequeue();

                ListNode nhead = new ListNode(head.val);
                current = nhead;
                int count = q.Count();
                int i = 0;
                if (count == 0)
                    return nhead;
                else
                {
                    for (i = 0; i < count; i++)
                    {
                        current.next.val = q.Dequeue();
                        current = current.next;
                    }

                    return nhead;
                }
            }
            else
                return head;
        }
            
            
        }

    }



