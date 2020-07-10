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
      LinkedList linkedList = new LinkedList();

      linkedList.AddNode(10);
      linkedList.AddNode(11);
      linkedList.AddNode(12);
      linkedList.AddNode(13);
      linkedList.AddNode(14);

      linkedList.PrintNodes();

      linkedList.ReverseLinkedList();

      linkedList.PrintNodes();

      TestAddingOfLists();
      TestAddingOfLists2();
      Console.ReadLine();
    }

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

      LinkedList linkedList = new LinkedList();
      Node node = linkedList.AddTwoLists(linkedList1.head, linkedList2.head);
    }

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

      LinkedList linkedList = new LinkedList();
      Node node = linkedList.AddTwoLists(linkedList1.head, linkedList2.head);
    }
  }

  internal class Node
  {
    internal int data;
    internal Node next;
  }

  class LinkedList
  {
    internal Node head;
    internal void AddNode(int i)
    {
      Node newNode = new Node();
      newNode.data = i;
      newNode.next = head;
      head = newNode;
    }

    internal void PrintNodes()
    {
      Node current = head;
      if (current == null)
      {
        Console.WriteLine("List Empty");
      }
      else
      {
        string listString = string.Empty;
        while (current != null)
        {
          listString = listString + current.data + "->";
          current = current.next;
        }
        listString = listString + "N";
        Console.WriteLine(listString);
      }
    }

    internal void ReverseLinkedList()
    {
      Node current = head;
      Node previous = null;

      while (current != null)
      {
        Node next = current.next;

        // reverse the pointer bond to previous
        current.next = previous;

        previous = current;
        current = next;

        if (current != null)
          head = current;
      }
    }

    internal Node AddTwoLists(Node X, Node Y)
    {
      Node sumHeadNode = null;
      Node prevNode = null;
      int carry = 0;
      while (X != null || Y != null || carry != 0)
      {
        int xData = (X == null) ? 0 : X.data;
        int yData = (Y == null) ? 0 : Y.data;
        int sum = xData + yData + carry;
        int val = sum % 10;
        carry = sum / 10;

        Node sumNode = new Node();
        sumNode.data = val;
        sumNode.next = null;

        if(prevNode == null)
        {
          sumHeadNode = sumNode;
        }
        else
        {
          prevNode.next = sumNode;
        }
        prevNode = sumNode;

        if (X != null)
          X = X.next;
        if (Y != null)
          Y = Y.next;
      }
      return sumHeadNode;
    }
  }
}
