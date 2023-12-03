using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlTypes;

namespace ConsoleCoding.AddTwoNumber_002
{
    internal class AddTwoNumbercs
    {
        ListNode l1;
        ListNode l2;
        public AddTwoNumbercs()
        {

            InitListNode oInit = new InitListNode();

            int[] ar1 = { 8, 3, 2 };
            int[] ar2 = { 9,2,1 };
            ListNode l11 = oInit.SetListNode(ar1);
            ListNode l21 = oInit.SetListNode(ar2);
           
            /*
            //ListNode l17 = new ListNode(9);
            //ListNode l16 = new ListNode(9);
            //ListNode l15 = new ListNode(9);
            //ListNode l14 = new ListNode(9);
            ListNode l13 = new ListNode(2);
            ListNode l12 = new ListNode(3);
            ListNode l11 = new ListNode(8);
            l11.next = l12;
            l12.next = l13;
            //l13.next = l14;
            //l14.next = l15;
            //l15.next = l16;
            //l16.next = l17;

            //ListNode l24 = new ListNode(9);
            ListNode l23 = new ListNode(1);
            ListNode l22 = new ListNode(2);
            ListNode l21 = new ListNode(9);
            l21.next = l22;
            l22.next = l23;
            //l23.next = l24;
            */

            ListNode ret = Process(l11, l21);
            Debug.WriteLine(ret);
        }

        public ListNode Process(ListNode l1, ListNode l2)
        {
            int v1 = l1.val;
            int v2 = l2.val;
           
            int tmp = (v1 + v2)>=10?(v1 + v2) % 10:(v1 + v2);
            int up = (v1 + v2) / 10;

            ListNode nd0 = new ListNode(tmp);
            ListNode nd = new ListNode(up);
            
            //if (tmp == 0 && up == 0)
            //{

            //}
            //else
            //{
            //    nd.next = nd0;
            //}

            while (true)
            {

                if (null == l1.next && null == l2.next)
                {
                    break;
                }
                else
                {
                    nd = AddList(nd, l1, l2);
                    break;
                }
            }

            ListNode ret = new ListNode();
            ret = new ListNode(nd.val);
            if (nd!=null && nd.next != null)
            {
                ret = reverseAsc(nd.next, ret);
            }
            
            return ret;
            
        }
        private ListNode AddSignleList(ListNode nd, ListNode lst)
        {
            int v1 = 0;
            int v2 = 0;
            int tmp = 0;
            int up = 0;

            while (true)
            {
                if (null == lst.next)
                {
                    
                    break;
                }
                else
                {
                    lst = lst.next;
                    v1 = lst.val;
                    tmp = (nd.val + v1) >= 10 ? (nd.val + v1) % 10 : (nd.val + v1);
                    up = (nd.val + v1) / 10;
                    nd.val = tmp;

                    ListNode t = nd;
                    nd = new ListNode(up);
                    nd.next = t;
                }
               
            }
            return nd;
        }
        private ListNode AddList(ListNode nd, ListNode l1,ListNode l2)
        {
            int v1 = 0;
            int v2 = 0;
            int tmp = 0;
            int up = 0;

            while (true)
            {
  
                if (null == l1.next && null != l2.next)
                {
                    nd = AddSignleList(nd, l2);
                    break;
                }
                else if (null == l2.next && null != l1.next)
                {
                    nd = AddSignleList(nd, l1);
                    break;
                }
                else
                {

                    l1 = l1.next;
                    l2 = l2.next;

                    tmp = (nd.val + l1.val + l2.val) >= 10 ? (nd.val + l1.val + l2.val) % 10 : (nd.val + l1.val + l2.val);
                    up = (nd.val + l1.val + l2.val) / 10;

                    nd.val = tmp;

                    if ((l1.next != null || l2.next != null) && up != 0)
                    {
                        ListNode t = nd;
                        nd = new ListNode(up);
                        nd.next = t;
                    }

                }

            }
            if (nd.val == 0)
            {
                return nd.next;
            }
            return nd;
        }
        private ListNode reverseAsc(ListNode nd, ListNode head)
        {
            if (null == nd.next)
            {
                return head = new ListNode(nd.val, head);
            }
            else
            {
                ListNode t = head;
                head = new ListNode(nd.val);
                head.next = t;

                head =  reverseAsc(nd.next, head);

                return head;
            }
        }
        private ListNode reverse(ListNode nd, ListNode nxt)
        {
            ListNode head = new ListNode();
            ListNode tmp = new ListNode();

            if (null == nxt.next)
            {
                return new ListNode(nxt.val, new ListNode(nd.val));
            }
            else
            {
                head = reverse(nxt, nxt.next);
                ListNode t = head;
                while (true)
                {
                    if (null == t.next)
                    {
                        t.next = new ListNode(nd.val);
                        break;
                    }
                    else
                    {
                        t = t.next;
                    }

                }
                return head;
            }
        }
    }
}
