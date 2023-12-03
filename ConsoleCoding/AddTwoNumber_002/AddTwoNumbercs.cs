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

            
            int[] ar1 = {3,7};
            int[] ar2 = { 9,2 };
            ListNode l11 = oInit.SetListNode(ar1);
            ListNode l21 = oInit.SetListNode(ar2);
 
            ListNode ret = Process(l11, l21);
            Debug.WriteLine(ret);
        }

        public ListNode Process(ListNode l1, ListNode l2)
        {
            int v1 = l1.val;
            int v2 = l2.val;
           
            int tmp = (v1 + v2)>=10?(v1 + v2) % 10:(v1 + v2);
            int up = (v1 + v2) / 10;

            ListNode nd = new ListNode(tmp);
            //ListNode nd = new ListNode(up);
            
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
                    if (up > 0)
                    {
                        ListNode t = nd;
                        nd = new ListNode(up);
                        nd.next = t;
                    }
                    break;
                }
                else
                {
                    nd = AddList(nd, l1, l2, up);
                    break;
                }
            }

            ListNode ret = new ListNode();
            ret = new ListNode(nd.val);
            if (nd!=null && nd.next != null)
            {
                ret = reverseAsc(nd.next, ret);
            }
            ListNodeFunctions.List(ret);
            return ret;
            
        }
        private ListNode AddSignleList(ListNode nd, ListNode lst, int up=0)
        {
            int v1 = 0;
            int v2 = 0;
            int tmp = 0;

            while (true)
            {
                if (null == lst.next)
                {
                    if (up > 0)
                    {
                        ListNode t = nd;
                        nd = new ListNode(up);
                        nd.next = t;
                    }
                    break;
                }
                else
                {
                    lst = lst.next;
                    v1 = lst.val;
                    tmp = (up + v1) >= 10 ? (up + v1) % 10 : (up + v1);
                    up = (up + v1) / 10;

                    ListNode t = nd;
                    nd = new ListNode(tmp);
                    nd.next = t;
                }
               
            }
            return nd;
        }
        private ListNode AddList(ListNode nd, ListNode l1,ListNode l2, int up=0)
        {
            int v1 = 0;
            int v2 = 0;
            int tmp = 0;
            

            while (true)
            {

                if (null == l1.next && null == l2.next)
                {
                    if (up > 0)
                    {
                        ListNode t = nd;
                        nd = new ListNode(up);
                        nd.next = t;
                    }
                    break;
                }

                if (null == l1.next && null != l2.next)
                {
                    nd = AddSignleList(nd, l2, up);
                    break;
                }
                else if (null == l2.next && null != l1.next)
                {
                    nd = AddSignleList(nd, l1, up);
                    break;
                }
                else
                {

                    l1 = l1.next;
                    l2 = l2.next;
                    //Sum up up and l1, l2
                    tmp = (up + l1.val + l2.val) >= 10 ? (up + l1.val + l2.val) % 10 : (up + l1.val + l2.val);
                    //Next up. 
                    up = (up + l1.val + l2.val) / 10;

                    ListNode tnd = nd;
                    nd = new ListNode(tmp);
                    nd.next = tnd;

                }

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
