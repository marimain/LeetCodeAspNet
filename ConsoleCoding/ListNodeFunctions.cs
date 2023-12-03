using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleCoding
{
    internal class ListNodeFunctions
    {
        public static void List(ListNode nd)
        {
            if (null == nd)
            {
                Debug.WriteLine("***No ListNode item in nd.***");
            }
            else
            {
                StringBuilder sb = new StringBuilder(nd.val.ToString());
                while (true)
                {
                    if (null != nd.next)
                    {
                        nd = nd.next;
                        string v = nd.val.ToString();
                        sb.Append(" " + v);
                    }
                    else
                    {
                        Debug.WriteLine(sb.ToString());
                        break;
                    }
                }
            }
        }
    }
}
