using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 5, 7, 8, 2, 10 };
            int[] sortedArray = SelectionSort(unsortedArray);
            Display(sortedArray);
            Console.ReadLine();
        }
        public static int[] SelectionSort(int[] array)
        {
            int minIndex;
            int temp;
            int n = array.Length;
            for (int i = 0; i < n-1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                    temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                
            }
            return array;
        }
        public static void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
        }
    }
}
