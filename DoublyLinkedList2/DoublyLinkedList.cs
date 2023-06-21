using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList2
{
    public class DoublyLinkedList
    {
        Random random = new Random();
        Node _root;
        public DoublyLinkedList Insert(DoublyLinkedList list, int data)
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
                newNode.previous = iter;
            }
            return list;
        }
        public void Print(DoublyLinkedList list)
        {
            Node iter = list._root;
            while (iter != null)
            {
                Console.Write(iter.data + " ");
                iter = iter.next;
            }
        }
        //the method which returns random numbers within boundary inputs given by user.
        public DoublyLinkedList RandomlyInsert(DoublyLinkedList list, int min, int max, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int x = random.Next(min, max);
                Node newNode = new Node(x);
                if (list._root == null)
                {
                    list._root = newNode;
                }
                else if (newNode.data < list._root.data)
                {
                    newNode.next = list._root;
                    list._root.previous = newNode;
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
                    newNode.previous = iter;

                    newNode.next = temp;

                    if (temp != null)
                    {
                        temp.previous = newNode;
                    }
                }
            }
            return list;
        }
    }
}
