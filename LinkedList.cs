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

        // Method to insert a node after a given node
        public void InsertNode(Node prevNode, int data)
        {
            if (prevNode == null)
            {
                Console.WriteLine("Previous node cannot be null.");
                return;
            }

            Node newNode = new Node(data);  // Create a new node with the given data

            newNode.Next = prevNode.Next;   // Assign the next reference of the new node to the next reference of the previous node

            prevNode.Next = newNode;        // Update the next reference of the previous node to point to the new node
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