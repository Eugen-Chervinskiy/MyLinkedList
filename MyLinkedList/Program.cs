using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
   class Program
   {
      static void Main(string[] args)
      {
         var node = new ListNode<int>(25);
         node.AddToEnd(11);

         node.PrintNode();
         Console.WriteLine();
         node.AddToEnd(25);
         node.AddToEnd(2222);
         node.PrintNode();
         Console.ReadKey();
      }
   }
}
