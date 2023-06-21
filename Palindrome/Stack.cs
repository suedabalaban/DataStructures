using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Stack
    { 
        int _top;
        int _size;
        char[] _dataArray;
        public Stack(int size)
        {
            _size = size;
            _top = -1;
            _dataArray = new char[size];
        }
        public void Push(char data)
        {
            if (CheckFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                _top++;
                _dataArray[_top] = data;
            }
        }
        public char Pop()
        {
            if (CheckEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return (char)0;
            }
            else
            {
                _top--;
                return _dataArray[_top + 1]; 
            }
        }
        public bool CheckEmpty()
        {
            return _top == -1;
        }
        public bool CheckFull()
        {
            return _top == _size - 1; 
        }
        public void Print()
        {
            Console.WriteLine("STACK");
            if (CheckEmpty())
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                for (int i = _top; i > -1; i--)
                {
                    Console.WriteLine(_dataArray[i]);
                }
            }
        }
    }
}
