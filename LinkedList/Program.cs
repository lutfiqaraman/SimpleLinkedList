using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();

            linkedlist.Add("A");
            linkedlist.Add("B");
            linkedlist.Add("C");

            linkedlist.PrintAllNodes();

            Console.ReadKey();

        }
    }
}
