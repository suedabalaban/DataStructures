using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInt
{
    public class LinkedList
    {
        Node _root; //private
        public LinkedList Insert(LinkedList list, int data)
        {
            Node newNode = new Node(data);
            if (list._root == null)
            {
                list._root = newNode;
            }
            else
            {
                Node iter = list._root;
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
            Node iter = list._root;
            while (iter != null)
            {
                Console.WriteLine(iter.data);
                iter = iter.next;
            }
        }
        public LinkedList OrderlyInsert(LinkedList list, int data)
        {
            Node newNode = new Node(data);
            if (list._root == null)
            {
                list._root = newNode;
            }
            if (list._root.data > newNode.data)
            {
                newNode.next = list._root;
                list._root = newNode;
            }
            else
            {
                Node iter = list._root;
                while (iter.next != null && iter.next.data < newNode.data)
                {
                    iter = iter.next;
                }
                Node temp = iter.next;
                iter.next = newNode;
                newNode.next = temp;
            }
            return list;
        }
        public LinkedList Delete(LinkedList list, int deletedData)
        {
            if (list._root != null && list._root.data == deletedData)
            {
                list._root = list._root.next;
            }
            else
            {
                Node iter = list._root;
                while (iter.next != null && iter.next.data != deletedData)
                {
                    iter = iter.next;
                }
                if (iter.next == null)
                {
                    Console.WriteLine("Data couldn't be found.");
                }
                else
                {
                    iter.next = iter.next.next;
                }
            }
            return list;
        }
        

        

    }
}
