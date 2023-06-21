using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 9, 5, 4, 163, 4, 53 };
            Console.WriteLine(LinearSearch(array, 5));
            Console.ReadLine();
        }
        public static int LinearSearch(int[] array, int data)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (data == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
