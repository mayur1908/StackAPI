using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();     // Create an instance of the LinkedList class

            list.Head = new Node(56);               // Create the first node with data 56
            Node secondNode = new Node(30);         // Create the second node with data 30
            Node thirdNode = new Node(70);          // Create the third node with data 70

            list.Head.Next = secondNode;            // Set the next reference of the head node to the second node
            secondNode.Next = thirdNode;            // Set the next reference of the second node to the third node

            list.Pop();                             // Delete the first node

            list.PrintList();                       // Print the linked list
        }
    }
}
