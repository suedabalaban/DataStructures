using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue(5);
            queue.EnQueue(4);
            queue.EnQueue(2);
            queue.EnQueue(5);
            queue.EnQueue(8);
            queue.EnQueue(9);

            queue.Print();

            queue.DeQueue();
            queue.EditQueue();
            queue.EnQueue(28);

            queue.Print();


            Console.ReadLine();
        }
    }
}
