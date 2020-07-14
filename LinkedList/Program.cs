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
      TestReversingOfLinkedList();
      TestAddingOfLists();
      TestAddingOfLists2();
      TestRemovingDuplictedFromLists();
      TestRemovingDuplictedFromListsWithExtraBufferAllowed();
      Console.ReadLine();
    }

    /// <summary>
    /// Question : reversing a linked list.
    /// </summary>
    static void TestReversingOfLinkedList()
    {
      LinkedList linkedList = LinkedListHelpers.GetLinkedListWithUniqueNodes();

      linkedList.PrintNodes();

      linkedList.ReverseLinkedList();

      linkedList.PrintNodes();
    }
    /// <summary>
    /// Question : Add two numbers represented in the linked lists. The sum be in th third linked list.
    /// </summary>
    static void TestAddingOfLists()
    {
      Console.WriteLine(nameof(TestAddingOfLists));
      LinkedList linkedList1 = new LinkedList();

      linkedList1.AddNode(3);
      linkedList1.AddNode(6);
      linkedList1.AddNode(5);

      LinkedList linkedList2 = new LinkedList();
      linkedList2.AddNode(2);
      linkedList2.AddNode(4);
      linkedList2.AddNode(8);

      Node node = LinkedListHelpers.AddTwoLists(linkedList1.head, linkedList2.head);

      LinkedListHelpers.PrintNodes(node);
    }

    /// <summary>
    /// Question : Add two numbers represented in the linked lists. The sum be in th third linked list.
    /// </summary>
    static void TestAddingOfLists2()
    {
      Console.WriteLine(nameof(TestAddingOfLists2));
      LinkedList linkedList1 = new LinkedList();

      linkedList1.AddNode(6);
      linkedList1.AddNode(4);
      linkedList1.AddNode(9);
      linkedList1.AddNode(5);
      linkedList1.AddNode(7);

      LinkedList linkedList2 = new LinkedList();
      linkedList2.AddNode(4);
      linkedList2.AddNode(8);

      Node node = LinkedListHelpers.AddTwoLists(linkedList1.head, linkedList2.head);

      LinkedListHelpers.PrintNodes(node);
    }

    /// <summary>
    /// Question : Removing the duplicates from a linked list. Extra space buffer not allowed.
    /// </summary>
    static void TestRemovingDuplictedFromLists()
    {
      Console.WriteLine(nameof(TestRemovingDuplictedFromLists));
      LinkedList linkedList = LinkedListHelpers.GetLinkedListWithRepeatedNodes();

      linkedList.PrintNodes();

      Node node = LinkedListHelpers.RemoveDuplicates(linkedList.head);

      LinkedListHelpers.PrintNodes(node);
    }

    /// <summary>
    /// Question : Removing the duplicates from a linked list. Extra space buffer not allowed.
    /// </summary>
    static void TestRemovingDuplictedFromListsWithExtraBufferAllowed()
    {
      Console.WriteLine(nameof(TestRemovingDuplictedFromListsWithExtraBufferAllowed));
      LinkedList linkedList = LinkedListHelpers.GetLinkedListWithRepeatedNodes();

      linkedList.PrintNodes();

      Node node = LinkedListHelpers.RemoveDuplicatesWithExtraBufferAllowed(linkedList.head);

      LinkedListHelpers.PrintNodes(node);
    }
  }
}
