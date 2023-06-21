using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInt
{
    public class Node
    {
        public int data; //data
        public Node next; //pointer
        public Node(int data)
        {
            this.data = data; 
            next = null;
        }
    }
}
