using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class LinkedListOperations
{
    // Method to print linked list
    public static void PrintList(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    // Reverse linked list using extra array
    public static ListNode ReverseListUsingArray(ListNode head)
    {
        if (head == null) return null;

        List<int> values = new List<int>();
        ListNode current = head;

        // Step 1: copy values to array
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }

        // Step 2: refill in reverse order
        current = head;
        for (int i = values.Count - 1; i >= 0; i--)
        {
            current.val = values[i];
            current = current.next;
        }

        return head;
    }
}

public class Program
{
    public static void Main()
    {
        // Create sample linked list: 1 -> 2 -> 3 -> 4 -> 5 -> null
        ListNode head = new ListNode(1,
                        new ListNode(2,
                          new ListNode(3,
                            new ListNode(4,
                              new ListNode(5)))));

        Console.WriteLine("Original List:");
        LinkedListOperations.PrintList(head);

        LinkedListOperations.ReverseListUsingArray(head);

        Console.WriteLine("Reversed List:");
        LinkedListOperations.PrintList(head);
    }
}
