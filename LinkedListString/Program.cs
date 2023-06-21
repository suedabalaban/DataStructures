using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListString
{
    public class Program
    {
        static void Main(string[] args)
        {

            LinkedList list = new LinkedList();
            list.Insert(list, "olive");
            list.Insert(list, "viridian");
            list.Insert(list, "emerald");
            list.Insert(list, "jade");
            list.Insert(list, "mint");
            list.Insert(list, "turquoise");

            Console.WriteLine("---Print---");

            list.Print(list);

            Console.WriteLine("---Delete---");

            list = list.DeleteByIndex(list, 2);
            list.Print(list);

            Console.WriteLine("---Display---");

            list.Display();

            Console.WriteLine("---Reverse---");

            list.PrintReverse(list.root);

            Console.WriteLine("---Search---");

            list.Search("jade");

            Console.ReadLine();
        }
    }
}
