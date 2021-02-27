using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CSC350_Project1
{
    public class Node
    {
        public Node next;
        public object data;
    }

    public class LinkedList
    {
        public Node head;

        public void add_first(object data)
        {
            Node n = new Node();
            n.data = data;
            n.next = head;

            head = n;
        }
        public void add_last(object data)
        {
            if (head == null)
            {
                head = new Node();

                head.data = data;
                head.next = null;
            }
            else
            {
                Node n = new Node();
                n.data = data;

                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }

                current.next = n;
            }
        }
        public void printNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
        }

    }
}
