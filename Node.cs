using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Data;    // Data stored in the node
        public Node Next;   // Reference to the next node

        public Node(int data)
        {
            Data = data;    // Assign the data value to the node
            Next = null;    // Set the next node reference to null initially
        }
    }
}
