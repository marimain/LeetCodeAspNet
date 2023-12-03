using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoding
{
    internal class InitListNode
    {
        public InitListNode() { }
        public ListNode SetListNode(int[] lst)
        {
            ListNode head = new ListNode(lst[lst.Length - 1]);

            for (int i = lst.Length - 2; i >= 0; i--)
            {
                ListNode t = head;
                head = new ListNode(lst[i]);
                head.next = t;
            }

            return head;
        }
    }
}
