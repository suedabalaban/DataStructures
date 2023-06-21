using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList2
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            //user input section

            Console.Write("Please determine the starting value of boundary: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please determine the ending value of boundary:");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please determine how many number to be printed: ");
            int count = Convert.ToInt32(Console.ReadLine());

            list.RandomlyInsert(list, start, end, count);

            list.Print(list);

            
        }
    }
}
