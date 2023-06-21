using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
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
                Console.WriteLine(iter.data);
                iter = iter.next;
            }
        }
        public void ReversePrint(DoublyLinkedList list)
        {
            Node iter = FindLastNode(list);
            while (iter != null)
            {
                Console.WriteLine(iter.data);
                iter = iter.previous;
            }
        }
        public Node FindLastNode(DoublyLinkedList list)
        {
            Node iter = list._root;
            while (iter.next != null)
            {
                iter = iter.next;
            }
            Console.WriteLine(iter.data);
            return iter;
        }
        public DoublyLinkedList OrderlyInsert(DoublyLinkedList list, int data)
        {
            Node newNode = new Node(data);
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
            return list;
        }
        public DoublyLinkedList Delete(DoublyLinkedList list, int deletedData) 
        {
            if (list._root.data == deletedData)
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
                    Console.WriteLine("There is no data in the list to be deleted.");
                }
                else
                {
                    if (iter.next.next != null)
                    {
                        iter.next.next.previous = iter;                      
                    }
                    iter.next = iter.next.next;
                    if (iter.next != null)
                    {
                        iter.next.previous = iter;
                    }
                }
            }
            return list;
        }
    }
}
