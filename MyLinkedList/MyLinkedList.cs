
namespace MyLinkedList
{
   using System;

   public class MyLinkedList<T>
   {
      public ListNode<T> First;
      public ListNode<T> Current;

      public int Count;
      
      public MyLinkedList()
      {
         this.First = null;
      }

     
      public void AddToEnd(T data)
      {
         var insertedNode = new ListNode<T>(data);

         if (First == null)
         {
            First = insertedNode;
            Count++;
            return;
         }

         Current = First;

         while (Current.NextNode != null)
         {
            Current = Current.NextNode;
         }

         Current.NextNode = insertedNode;
         Count++;
      }

      public void AddToBeginning(T data)
      {
         var insertedNode = new ListNode<T>(data);
         insertedNode.NextNode = First;
         First = insertedNode;
         Count++;
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
            Count--;
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
            Count--;
         }
      }
      
      
      public void Insert(T data,int position)
      {
         ListNode<T> insertionElement;
         if (position > Count)
         {
            Console.WriteLine("Position bigger then list count");
            return;
         }

         if (position == 1)
         {
            insertionElement = new ListNode<T>(data);
            insertionElement.NextNode = First;
            First = insertionElement;
            Count++; 
            return;
         }

         Current = First;
         for (int i = 0; i < position - 1 && Current != null; i++)
         {
            Current = Current.NextNode;

         }
         if (Current == null)
         {
            Console.WriteLine($"Wrong inserting position");
         }

         else
         {
            insertionElement = new ListNode<T>(data);
            insertionElement.NextNode = Current.NextNode;
            Current.NextNode = insertionElement;
            Count++;
         }
      }

      public bool IsContainValue(T data)
      {
         var searchingElement = First;
         for (int i = 0; i < Count; i++)
         {
            if (searchingElement == null)
            {
               return false;
            }

            else if (searchingElement.Data.Equals(data))
            {
               return true;
            }

            else
            {
               searchingElement = searchingElement.NextNode;
            }
         }

         return false;
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
