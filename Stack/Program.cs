using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackExample stack = new StackExample(5);
            stack.Push(25);
            stack.Push(20);
            stack.Push(15);
            stack.Push(10);
            stack.Push(5);

            stack.Override(16);

            stack.Print();

            Console.ReadLine();
        }
    }
}
