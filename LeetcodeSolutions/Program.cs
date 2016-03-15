using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //MainAddDigital(args);
            //MainReverseLinkedList(args);
           // MainRomanToInt(args);
            //MainRemoveDuplicatesFromSortedlist(args);
            MainHappyNumber(args);
        }
        static void MainHappyNumber(string[] args)
        {

            HappyNumber.Solution s = new HappyNumber.Solution();

            Console.WriteLine(s.IsHappy(199898));
            Console.ReadLine();

        }
        static void MainAddDigital(string[] args)
        {
            AddDigital.Solution s = new AddDigital.Solution();
            Console.WriteLine(s.MyAddDigits(339594));
            Console.ReadLine();
        }
        static void MainReverseLinkedList(string[] args)
        {
            //ReverseLinkedList.ListNode root = new ReverseLinkedList.ListNode(1);
            //root.next =

            //ReverseLinkedList.Solution s = new ReverseLinkedList.Solution();
            Console.WriteLine();
            //Console.ReadLine();

            //ListNode root = new ListNode(1);
            //ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(1);
            //ListNode node3 = new ListNode(1);
            //ListNode node4 = new ListNode(1);
            //ListNode node5 = new ListNode(1);
            //ListNode node6 = new ListNode(1);
            //ListNode node7 = new ListNode(1);
            //root.next = node1;
            //node1.next = node2;

            ReverseLinkedList.ListNode root = new ReverseLinkedList.ListNode(1);
            ReverseLinkedList.ListNode head = root;
            for (int i=1; i < 10; i++ )
            {
                root.next = new ReverseLinkedList.ListNode(i + 1);
                root = root.next;
            }

            //while (head.next != null)
            //{
            //    Console.WriteLine(head.val);
            //    head = head.next;
            //}

            ReverseLinkedList.Solution s = new ReverseLinkedList.Solution();
            ReverseLinkedList.ListNode n = s.ReverseList(head);
            while (n.next != null)
            {
                Console.WriteLine(n.val);
                n = n.next;
            }
            Console.ReadLine();

        }
        static void MainRomanToInt(string[] args)
        {
            RomanToInt.Solution s = new RomanToInt.Solution();
            int res = s.RomanToInt("MCMXCVI");
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static void MainRemoveDuplicatesFromSortedlist(string[] args)
        {
            RemoveDuplicatesFromSortedlist.ListNode head = new RemoveDuplicatesFromSortedlist.ListNode(1);
            head.next = new RemoveDuplicatesFromSortedlist.ListNode(1);
            RemoveDuplicatesFromSortedlist.Solution s = new RemoveDuplicatesFromSortedlist.Solution();
            RemoveDuplicatesFromSortedlist.ListNode n = s.DeleteDuplicates(head);
            while (n!= null)
            {
                Console.WriteLine(n.val);
                n = n.next;
            }
            Console.ReadLine();

        }

    }
   
}
