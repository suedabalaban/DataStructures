using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 8, 61, 22, 1, 54, 29 };
            Console.WriteLine(BinarySearch(array, 8));
            Console.ReadLine();
        }
        public static int BinarySearch(int[] array, int data)
        {
            int start = 0, end = array.Length - 1;
            while (start<=end)
            {
                int middle = (start + end) / 2;
                if (array[middle] > data)
                {
                    end = middle - 1;
                }
                else if (array[middle] < data)
                {
                    start = middle + 1;
                }
                else
                {
                    return ++middle;
                }
            }
            return -1;
        }
    }
}
