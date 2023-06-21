using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListInt
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.OrderlyInsert(list, 1);
            list.OrderlyInsert(list, 5);
            list.OrderlyInsert(list, 3);
            list.OrderlyInsert(list, 7);
            list.OrderlyInsert(list, 4);

            list.Delete(list, 8);

            list.Print(list);

            Console.ReadLine();
        }
    }
}
