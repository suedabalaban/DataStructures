using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 5, 64, 15, 89, 52, 32, 127, 2, 55 };
            int[] sortedArray = QuickSort(unsortedArray, 0, unsortedArray.Length - 1);
            Display(sortedArray);
            Console.ReadLine();
        }
        public static int[] QuickSort(int[] array, int low, int high)
        {
            if (array == null || array.Length == 0)
            {
                return array;
            }
            if (low >= high)
            {
                return array;
            }
            int middle = low + (high - low) / 2;
            int pivot = array[middle];

            int i = low, j = high;
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }
            //recursive method
            if (low < j)
            {
                QuickSort(array, low, j);
            }
            if (high > i)
            {
                QuickSort(array, i, high);
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
