using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace leetcode
{


    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class MergeTwoSortedLists21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            
            if (list1 is null) return list2;
            if (list2 is null) return list1;

            ListNode result = new ListNode();
            var list = result;
            if (list1.val < list2.val)
            {
                list.val = list1.val;
                list1 = list1.next;
                list.next = new ListNode();
                list = list.next;
            }
            else
            {
                list.val = list2.val;
                list2 = list2.next;
                list.next = new ListNode();
                list = list.next;
            }

            while(true)
            {
                if (list1 != null && list2 != null)
                {
                    if (list1.val < list2.val)
                    {
                        list.val = list1.val;
                        list1 = list1.next;
                        list.next = new ListNode();
                        list = list.next;
                    }
                    else
                    {
                        list.val = list2.val;
                        list2 = list2.next;
                        list.next = new ListNode();
                        list = list.next;
                    }
                }
                else if (list1 != null)
                {
                    list.val = list1.val;
                    list1 = list1.next;
                    list.next = new ListNode();
                    list = list.next;
                }
                else if (list2 != null)
                {
                    list.val = list2.val;
                    list2 = list2.next;
                    list.next = new ListNode();
                    list = list.next;
                }
                else break;
            }
            for(list = result; list.next.next != null; list = list.next) { }
            list.next = null;
            GC.Collect();
            return result;
        }

        //public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        //{

        //    if (list1 is null) return list2;
        //    if (list2 is null) return list1;

        //    if (list1.val < list2.val)
        //    {
        //        list1.next = MergeTwoLists(list1.next, list2);
        //        return list1;
        //    }
        //    else
        //    {
        //        list2.next = MergeTwoLists(list1, list2.next);
        //        return list2;
        //    }
        //}
    }
}
