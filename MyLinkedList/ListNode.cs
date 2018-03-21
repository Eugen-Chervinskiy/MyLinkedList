
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
   }
}

