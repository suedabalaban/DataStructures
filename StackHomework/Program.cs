using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size of the stack: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            MyStack stack = new MyStack(amount);

            Console.Write("Please input the stack members to push: ");
            for (int i = 0; i < amount; i++)
            {              
                int data = Convert.ToInt32(Console.ReadLine());
                stack.Push(data);
            }
            stack.Print();
            Console.Write("Please input the number to delete: ");
            int deleted = Convert.ToInt32(Console.ReadLine());
            stack.Delete(deleted);
            stack.Print();

            stack.Swap();
            Console.WriteLine("Swap operation: ");
            stack.Print();


            Console.ReadLine();
        }
    }
}
