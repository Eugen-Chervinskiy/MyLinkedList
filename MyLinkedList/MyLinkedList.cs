

namespace MyLinkedList
{
   using System;

   public class MyLinkedList<T>
   {
      public ListNode<T> First;
      public ListNode<T> Current;

      public int Count
      {
         get
         {
            return GetListCount();
         }
      }
      public MyLinkedList()
      {
         this.First = null;
      }

      private int GetListCount()
      {
         var iterator = this.First;
         var count = 0;
         while (iterator != null)
         {
            count++;
            iterator = iterator.NextNode;
         }

         return count;
      }


      public void AddToEnd(T data)
      {
         var insertedNode = new ListNode<T>(data);

         if (First == null)
         {
            First = insertedNode;
            return;
         }

         Current = First;

         while (Current.NextNode != null)
         {
            Current = Current.NextNode;
         }

         Current.NextNode = insertedNode;
      }

      public void AddToBeginning(T data)
      {
         var insertedNode = new ListNode<T>(data);
         insertedNode.NextNode = First;
         First = insertedNode;
      }

      public void DeleteNode(T data)
      {
         if (First == null)
         {
            throw new InvalidOperationException(
               "You are trying to delete from an empty list");
         }

         if (First.Data.Equals(data))
         {
            First = First.NextNode;
            return;
         }

         Current = First;
         while (Current.NextNode != null)
         {
            if (Current.NextNode.Data.Equals(data))
            {
               break;
            }

            Current = Current.NextNode;
         }

         if (Current.NextNode == null)
         {
            Console.WriteLine("Element not found");
         }

         else
         {
            Current.NextNode = Current.NextNode.NextNode;
         }
      }
      
      

      public void PrintAllNodes()
      {
         var iterator = this.First;
         while (iterator != null)
         {
            Console.Write("|" + iterator.Data + "|-> ");
            iterator = iterator.NextNode;
         }

         Console.WriteLine('\n');
      }

   }
}
