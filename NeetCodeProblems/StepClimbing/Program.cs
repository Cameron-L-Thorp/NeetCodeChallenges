namespace ReverseLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public static class Reversal
    {
        public static ListNode ReverseLinkedList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            
            while (current != null)
            {
                ListNode temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            head = prev;
            return head;

        }
    }






 //Definition for singly-linked list.
    public class ListNode 
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) 
        {
            this.val = val;
            this.next = next;
        }
    }
 

}