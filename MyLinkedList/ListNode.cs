using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
   public class ListNode<T>
   {
      public ListNode<T> NextNode;
      public T Data;

      public ListNode(T data)
      {
         this.Data = data;
         this.NextNode = null;
      }

      public void PrintNode()
      {
         Console.Write("|" + Data + "|-> ");
         if (NextNode != null)
         {
            NextNode.PrintNode();
         }
      }

      public void AddToEnd(T data)
      {
         if (NextNode == null)
         {
            NextNode = new ListNode<T>(data);
         }
         else
         {
            NextNode.AddToEnd(data);
         }
      }
   }
}

