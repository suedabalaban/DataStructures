using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CircularList list = new CircularList();
            list.OrderlyInsert(list, 6);
            list.OrderlyInsert(list, 5);
            list.OrderlyInsert(list, 9);
            list.OrderlyInsert(list, 15);
            list.OrderlyInsert(list, 3);

            list.Delete(list, 15);

            list.Print(list);

            Console.ReadLine();
        }
    }
}
