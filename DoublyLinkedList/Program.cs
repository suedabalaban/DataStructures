using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();
            list.OrderlyInsert(list, 2);
            list.OrderlyInsert(list, 1);
            list.OrderlyInsert(list, 3);
            list.OrderlyInsert(list, 8);
            list.OrderlyInsert(list, 7);

            list.ReversePrint(list);
            list.FindLastNode(list);

            list.Delete(list, 7);
            list.Print(list);

            Console.ReadLine();
        }
    }
}
