
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

         list.Insert(25, 10);

         Console.WriteLine(list.IsContainValue(0));
         
         Console.ReadKey();
      }
   }
}
