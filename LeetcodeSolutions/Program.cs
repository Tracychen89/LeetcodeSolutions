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
            //MainHappyNumber(args);

            //MainIntersectionOfTwoLinkedList(args);

            //MainReverseBits(args);

            MainBubbleSort(args);
            
        }

        static void MainBubbleSort(string[] args)
        {
            BubbleSort.Program s = new BubbleSort.Program();
            int[] arry = new int[10000];
            Random r = new Random();
            for (int i = 0; i < 10000; i++)
            {

                arry[i] = r.Next(1, 10000);
                Console.Write(arry[i]);
            }
            int[] res = new int[10000];
            res = s.SortArray(arry);
            for(int j = 0; j<10000; j++)
            {
                Console.Write(res[j]);
            }
            Console.ReadLine();
        }



        static void MainReverseBits(string[] args)
        {
            ReverseBits.Solution s = new ReverseBits.Solution();
            Console.WriteLine(s.reverseBits(43261596));
            Console.ReadLine();


        }
        //static void MainIntersectionOfTwoLinkedList(string[] args)
        //{
        //    IntersectionOfTwoLinkedList.Solution s = new IntersectionOfTwoLinkedList.Solution();
        //    IntersectionOfTwoLinkedList.ListNode headA = new IntersectionOfTwoLinkedList.ListNode(1);
        //    headA.next = new IntersectionOfTwoLinkedList.ListNode(4);
        //    headA.next.next = new IntersectionOfTwoLinkedList.ListNode(5);
        //    headA.next.next.next = new IntersectionOfTwoLinkedList.ListNode(6);
        //    IntersectionOfTwoLinkedList.ListNode headB = new IntersectionOfTwoLinkedList.ListNode(2);
        //    headB.next = new IntersectionOfTwoLinkedList.ListNode(3);
        //    headB.next.next = new IntersectionOfTwoLinkedList.ListNode(5);
        //    headB.next.next.next = new IntersectionOfTwoLinkedList.ListNode(6);

        //    IntersectionOfTwoLinkedList.ListNode result;
        //   result = s.getIntersectionNode(headA, headB);

        //    while(result != null)
        //    {
        //        Console.WriteLine(result.val);
        //        result = result.next;
        //    }
        //    Console.ReadLine();

        //}
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
