using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAPI
{
    public class Program
    {
        // Node class represents a single node in the linked list
        public class Node
        {
            public int Data; // Data stored in the node
            public Node Next; // Reference to the next node in the list

            public Node(int data)
            {
                Data = data;
                Next = null;
            }
        }

        // Stack class represents a stack implemented using a linked list
        public class Stack
        {
            private Node top; // Reference to the top node of the stack

            public Stack()
            {
                top = null; // Initialize the stack with no nodes
            }

            // Push method adds a new node with the given data to the top of the stack
            public void Push(int data)
            {
                Node newNode = new Node(data); // Create a new node with the given data

                if (top == null)
                {
                    // If the stack is empty, make the new node the top node
                    top = newNode;
                }
                else
                {
                    // If the stack is not empty, add the new node at the top and update the references
                    newNode.Next = top; // Set the next reference of the new node to the current top node
                    top = newNode; // Update the top reference to the new node
                }
            }

            // Pop method removes and returns the data from the top of the stack
            public int Pop()
            {
                if (top == null)
                {
                    throw new InvalidOperationException("Stack is empty"); // Throw an exception if the stack is empty
                }

                int data = top.Data; // Retrieve the data from the top node
                top = top.Next; // Update the top reference to the next node

                return data; // Return the data from the top node
            }

            // Peek method returns the data from the top of the stack without removing it
            public int Peek()
            {
                if (top == null)
                {
                    throw new InvalidOperationException("Stack is empty"); // Throw an exception if the stack is empty
                }

                return top.Data; // Return the data from the top node
            }
        }

        static void Main(string[] args)
        {
            Stack stack = new Stack(); // Create a new stack object

            // Push the elements to the stack in the desired order: 70, 30, 56
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            // Print the elements of the stack by popping them one by one
            while (true)
            {
                try
                {
                    int data = stack.Pop(); // Pop the top element from the stack
                    Console.WriteLine(data); // Print the popped element
                }
                catch (InvalidOperationException)
                {
                    break; // Exit the loop if the stack is empty
                }
            }
        }
    }
}
