using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class CheckPalindrome
    {
        Stack _stack;
        Queue _queue;

        public CheckPalindrome(Stack stack, Queue queue)
        {
            _stack = stack;
            _queue = queue;
        }

        public void PalindromeCheck()
        {
            while (!_stack.CheckEmpty())
            {
                if (_stack.Pop() != _queue.DeQueue())
                {
                    Console.WriteLine("The word is not a palindrome");
                    return;
                }
            }
            Console.WriteLine("The word is a palindrome");
        }
    }
}
