using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {            
            

            Console.Write("Please enter the word: ");
            string input  = Convert.ToString(Console.ReadLine());

           
            Stack stack = new Stack(input.Length);
            Queue queue = new Queue(input.Length);

            char[] word = input.ToCharArray();
            CheckPalindrome palindrome = new CheckPalindrome(stack,queue);
            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
                queue.EnQueue(word[i]);
            }
            stack.Print();
            queue.Print();

            palindrome.PalindromeCheck();
          
            Console.ReadLine();
            
        }
    }
}
