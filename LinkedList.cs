using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedList
    {
        public Node Head;   // Head node of the linked list

        // Method to append a node at the end of the linked list
        public void AppendNode(int data)
        {
            Node newNode = new Node(data);  // Create a new node with the given data

            if (Head == null)
            {
                Head = newNode;   // If the list is empty, make the new node as the head
            }
            else
            {
                Node current = Head;

                while (current.Next != null)
                {
                    current = current.Next;   // Traverse to the last node
                }

                current.Next = newNode;   // Append the new node at the end
            }
        }

        // Method to traverse and print the linked list
        public void PrintList()
        {
            Node current = Head;    // Start from the head node

            while (current != null)
            {
                Console.Write(current.Data + " ");   // Print the data of the current node
                current = current.Next;               // Move to the next node
            }
        }
    }
}
