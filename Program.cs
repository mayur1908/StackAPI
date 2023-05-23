using System;
using System.Collections;
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

        // Queue class represents a queue implemented using a linked list
        public class Queue
        {
            private Node front; // Reference to the front node of the queue
            private Node rear; // Reference to the rear node of the queue

            public Queue()
            {
                front = null; // Initialize the queue with no nodes
                rear = null;
            }

            // Enqueue method adds a new node with the given data to the rear of the queue
            public void Enqueue(int data)
            {
                Node newNode = new Node(data); // Create a new node with the given data

                if (rear == null)
                {
                    // If the queue is empty, make the new node both the front and rear node
                    front = newNode;
                    rear = newNode;
                }
                else
                {
                    // If the queue is not empty, add the new node at the rear and update the references
                    rear.Next = newNode; // Set the next reference of the current rear node to the new node
                    rear = newNode; // Update the rear reference to the new node
                }
            }

            // Dequeue method removes and returns the data from the front of the queue
            public int Dequeue()
            {
                if (front == null)
                {
                    throw new InvalidOperationException("Queue is empty"); // Throw an exception if the queue is empty
                }

                int data = front.Data; // Retrieve the data from the front node

                if (front == rear)
                {
                    // If there is only one node in the queue, set both front and rear references to null
                    front = null;
                    rear = null;
                }
                else
                {
                    // If there are multiple nodes in the queue, update the front reference to the next node
                    front = front.Next;
                }

                return data; // Return the data from the front node
            }
        }
        public static void Main(string[] args)
        {
            Queue queue = new Queue(); // Create a new queue object

            // Enqueue the elements to the queue in the desired order: 56, 30, 70
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            // Dequeue and print elements from the queue until it is empty
            while (true)
            {
                try
                {
                    int data = queue.Dequeue(); // Dequeue the front element from the queue
                    Console.WriteLine(data); // Print the dequeued element
                }
                catch (InvalidOperationException)
                {
                    break; // Exit the loop if the queue is empty
                }
            }
        }
    }
}