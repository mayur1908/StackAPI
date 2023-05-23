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

        // Method to add a node at the beginning of the linked list
        public void AddNode(int data)
        {
            Node newNode = new Node(data);  // Create a new node with the given data
            newNode.Next = Head;            // Set the next reference of the new node to the current head
            Head = newNode;                 // Update the head to point to the new node
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
