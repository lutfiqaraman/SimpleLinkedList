using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        private Node head;

        public void Add(object data)
        {
            if (head == null)
            {
                head = new Node();

                head.dataofnode = data;
                head.next = null;
            }
            else
            {
                Node node = new Node();

                node.dataofnode = data;

                Node current = head;

                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = node;
            }
        }

        public void PrintAllNodes()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.dataofnode + "\t");
                current = current.next;
            }
        }
    }
}
