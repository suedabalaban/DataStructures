
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVLTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();
            tree.root = tree.InsertNode(tree.root, 23);
            tree.root = tree.InsertNode(tree.root, 13);
            tree.root = tree.InsertNode(tree.root, 56);
            tree.root = tree.InsertNode(tree.root, 27);
            tree.root = tree.InsertNode(tree.root, 33);
            tree.root = tree.InsertNode(tree.root, 11);
            tree.root = tree.InsertNode(tree.root, 99);
            tree.Print(tree.root, "", true);
            Console.ReadLine();
        }
    }
}
