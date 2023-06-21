using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, -9, -70, 2, 6 };
            Program mainObj = new Program();
            mainObj.Display(array);
            Console.WriteLine();
            int[] sortedArray = mainObj.InsertionSort(array);
            mainObj.Display(sortedArray);
            Console.ReadLine();
        }
        public int[] InsertionSort(int[] unsortedArray)
        {
            int n = unsortedArray.Length;

            for (int i = 1; i < n; i++)
            {
                int j = i;
                int iValue = unsortedArray[i];
                while ((j > 0) && unsortedArray[j - 1] > iValue)
                {
                    unsortedArray[j] = unsortedArray[j - 1];
                    j--;
                }
                unsortedArray[j] = iValue;
            }
            return unsortedArray;
        }
        public void Display(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
