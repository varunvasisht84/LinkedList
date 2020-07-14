using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
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
      LinkedListHelpers.PrintNodes(head);
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
  }

  class LinkedListHelpers
  {
    internal static Node AddTwoLists(Node X, Node Y)
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

        if (prevNode == null)
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

    internal static Node RemoveDuplicates(Node node)
    {
      Node current = node;
      while(current != null)
      {
        Node next = current.next;
        Node prevToNext = current;
        while (next != null)
        {
          if(current.data == next.data)
          {
            prevToNext.next = next.next;
          }
          prevToNext = next;
          next = next.next;
        }
        current = current.next;
      }
      return node;
    }

    internal static void PrintNodes(Node node)
    {
      if (node == null)
      {
        Console.WriteLine("List Empty");
      }
      else
      {
        string listString = string.Empty;
        while (node != null)
        {
          listString = listString + node.data + "->";
          node = node.next;
        }
        listString = listString + "N";
        Console.WriteLine(listString);
      }
    }

    internal static LinkedList GetLinkedListWithUniqueNodes()
    {
      LinkedList linkedList = new LinkedList();

      linkedList.AddNode(10);
      linkedList.AddNode(11);
      linkedList.AddNode(12);
      linkedList.AddNode(13);
      linkedList.AddNode(14);

      return linkedList;
    }

    internal static LinkedList GetLinkedListWithRandomNodes(int numberOfNodes)
    {
      LinkedList linkedList = new LinkedList();

      Random random = new Random();
      for (int i = 0; i < numberOfNodes; i++)
      {
        linkedList.AddNode(random.Next(0, 100));
      }

      return linkedList;
    }

    internal static LinkedList GetLinkedListWithRepeatedNodes()
    {
      LinkedList linkedList = new LinkedList();

      linkedList.AddNode(10);
      linkedList.AddNode(11);
      linkedList.AddNode(11);
      linkedList.AddNode(12);
      linkedList.AddNode(13);
      linkedList.AddNode(13);
      linkedList.AddNode(14);
      linkedList.AddNode(15);
      linkedList.AddNode(14);
      linkedList.AddNode(10);

      return linkedList;
    }
  }
}
