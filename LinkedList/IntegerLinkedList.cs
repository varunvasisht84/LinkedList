using System;
using System.Collections.Generic;
using System.Linq;
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
  }
}
