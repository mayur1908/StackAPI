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

        // Method to delete the first node in the linked list
        public void Pop()
        {
            if (Head == null)
            {
                Console.WriteLine("The linked list is already empty.");
                return;
            }

            Head = Head.Next;   // Update the head to the next node, effectively deleting the first node
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