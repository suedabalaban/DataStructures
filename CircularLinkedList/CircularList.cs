using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    public class CircularList
    {
       public Node root;
       public CircularList Insert(CircularList list, int data)
       {
            Node newNode = new Node(data);
            if (list.root == null)
            {
                list.root = newNode;
                list.root.next = list.root;
            }
            else
            {
                Node iter = list.root;
                while (iter.next != list.root)
                {
                    iter = iter.next;
                }
                iter.next = newNode;
                newNode.next = list.root;
            }
            return list;
       }
       public void Print(CircularList list)
       {
            Node iter = list.root;
            Console.WriteLine(iter.data);
            iter = iter.next;
            while (iter != list.root)
            {
                Console.WriteLine(iter.data);
                iter = iter.next;
            }
        }        
       public CircularList OrderlyInsert(CircularList list, int data)
       {
            Node newNode = new Node(data);
            if (list.root == null)
            {
                list.root = newNode;
                list.root.next = list.root;
            }
            if (newNode.data < list.root.data )
            {
                Node iter = list.root;
                while (iter.next != list.root)
                {
                    iter = iter.next;
                }
                iter.next = newNode;
                newNode.next = list.root;
                list.root = newNode;
            }
            else
            {
                Node iter = list.root;
                while (iter.next != list.root && iter.next.data < newNode.data)
                {
                    iter = iter.next;
                }
                Node temp = iter.next;
                iter.next = newNode;
                newNode.next = temp;
            }
            return list;
       }
        public CircularList Delete(CircularList list, int data)
        {
            Node iter = list.root;
            if (list.root.data == data)
            {
                while (iter.next != list.root)
                {
                    iter = iter.next;
                }
                iter.next = list.root.next;
                list.root = list.root.next;
            }
            else
            {
                while (iter.next != list.root && iter.next.data != data)
                {
                    iter = iter.next;
                }
                if (iter.next == list.root)
                {
                    Console.WriteLine("There is no data in the list to be deleted.");
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
