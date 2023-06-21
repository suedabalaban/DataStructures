using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListString
{
    public class LinkedList
    {
        public Node root;

        public LinkedList Insert(LinkedList list, string data)
        {
            Node newNode = new Node(data);
            if (list.root == null)
            {
                list.root = newNode;
            }
            else
            {
                Node iter = list.root;
                while (iter.next != null)
                {
                    iter = iter.next;
                }
                iter.next = newNode;
            }

            return list;
        }
        public void Print(LinkedList list)
        {
            Node iter = list.root;
            while (iter != null)
            {
                Console.WriteLine(iter.data);
                iter = iter.next;
            }
        }
        public LinkedList DeleteByIndex(LinkedList list, int index)
        {
            Node iter = list.root;
            if (index == 0)
            {
                list.root = iter.next;
                return list;
            }
            else
            {
                for (int i = 0; iter != null && i < index - 1; i++)
                {
                    iter = iter.next;
                }
                Node temp = iter.next.next;
                iter.next = temp;
                return list;
            }
        }
        public int Display()
        {
            int i = 0;
            Node temp = root;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
                i++;
            }
            return i;
        }
        public void PrintReverse(Node root)
        {
            if (root.next != null)
            {
                PrintReverse(root.next);
            }
            Console.WriteLine(root.data);
            return;
        }
        public void Search(string x)
        {
            Node iter = root;
            int i = 0;
            while (iter != null)
            {
                if (iter.data == x)
                {
                    Console.WriteLine("Data has been found in {0}th index.", i);
                }
                iter = iter.next;
                i++;
            }
        }
    }
}
