using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class Node
    {
        public int data;
        public int height;
        public Node left, right;
        public Node(int dataParam)
        {
            this.data = dataParam;
            this.height = 1;
        }
    }
}
