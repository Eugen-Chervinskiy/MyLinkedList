
namespace MyLinkedList
{
   using System;

   class Program
   {
      static void Main(string[] args)
      {
         var list = new MyLinkedList<int>();

         list.AddToBeginning(10);
         list.AddToBeginning(5);
         list.AddToBeginning(10);
         list.AddToEnd(25);
         list.AddToEnd(3);

         list.PrintAllNodes();

         Console.WriteLine();

         list.DeleteNode(10);

         list.PrintAllNodes();
         

         Console.WriteLine(list.Count);
         Console.ReadKey();
      }
   }
}
