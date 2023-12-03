using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleCoding
{
	internal class ListNode
	{
		public ListNode()
		{
		}
		public int val;
		public ListNode next;

		public ListNode(int x)
		{
			val = x;
		}
		public ListNode(int x, ListNode nextNode)
		{
			val = x;
			next = nextNode;
		}
	}
	
}