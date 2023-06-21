using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedArray = { 3, 1, 67, 21, 1234, 768, 14, 8 };
            
            int[] sortedArray = MergeSort(unsortedArray, 0, unsortedArray.Length-1);
            Display(sortedArray);
            Console.ReadLine();

        }
        public static int[] MergeSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;
                MergeSort(array, low, middle);
                MergeSort(array, middle + 1, high);
                Merge(array,low,middle,high);
            }
            return array;
        }
        public static void Merge(int[] array, int low, int middle, int high)
        {
            int[] array2 = new int[array.Length];
            int i, j, k;
            //backup array
            for (i = low; i <= high; i++)
            {
                array2[i] = array[i];
            }
            i = low; k = low; j = middle + 1;
            while (i <= middle && j<=high)
            {
                if (array2[i] <= array2[j])
                {
                    array[k++] = array2[i++];
                }
                else
                {
                    array[k++] = array2[j++];
                }
            }
            while (i <= middle)
            {
                array[k++] = array2[i++];
            }
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
