﻿using System;
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
      Console.ReadLine();
    }

    /// <summary>
    /// Question : reversing a linked list.
    /// </summary>
    static void TestReversingOfLinkedList()
    {
      LinkedList linkedList = new LinkedList();

      linkedList.AddNode(10);
      linkedList.AddNode(11);
      linkedList.AddNode(12);
      linkedList.AddNode(13);
      linkedList.AddNode(14);

      linkedList.PrintNodes();

      linkedList.ReverseLinkedList();

      linkedList.PrintNodes();
    }
    /// <summary>
    /// Question : Add two numbers represented in the linked lists. The sum be in th third linked list.
    /// </summary>
    static void TestAddingOfLists()
    {
      LinkedList linkedList1 = new LinkedList();

      linkedList1.AddNode(3);
      linkedList1.AddNode(6);
      linkedList1.AddNode(5);

      LinkedList linkedList2 = new LinkedList();
      linkedList2.AddNode(2);
      linkedList2.AddNode(4);
      linkedList2.AddNode(8);

      Node node = LinkedList.AddTwoLists(linkedList1.head, linkedList2.head);
    }

    /// <summary>
    /// Question : Add two numbers represented in the linked lists. The sum be in th third linked list.
    /// </summary>
    static void TestAddingOfLists2()
    {
      LinkedList linkedList1 = new LinkedList();

      linkedList1.AddNode(6);
      linkedList1.AddNode(4);
      linkedList1.AddNode(9);
      linkedList1.AddNode(5);
      linkedList1.AddNode(7);

      LinkedList linkedList2 = new LinkedList();
      linkedList2.AddNode(4);
      linkedList2.AddNode(8);

      Node node = LinkedList.AddTwoLists(linkedList1.head, linkedList2.head);
    }
  }
}
