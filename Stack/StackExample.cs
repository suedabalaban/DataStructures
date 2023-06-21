using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class StackExample
    {
        int _top; //last member of the stack
        int _size; //size of the stack
        int[] _dataArray; //data array that represents the stack
        public StackExample(int size)
        {
            _size = size;
            _top = -1;
            _dataArray = new int[size];
        }
        public void Push(int data)
        {
            if (StackCheckFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                _top++;
                _dataArray[_top] = data;
            }
        }
        public int Pop()
        {
            if (StackCheckEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                _top--;
                return _dataArray[_top+1]; //return to deleted data
            }
        }
        public bool StackCheckFull()
        {
            if (_top == _size -1)
            {
                return true;
            }
            return false;
        }
        public bool StackCheckEmpty()
        {
            if (_top == -1)
            {
                return true;
            }
            return false;
        }
        public void StackReset()
        {
            _top = -1;
        }
        public void Print()
        {
            if (StackCheckEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for (int i = _top; i > -1 ; i--)
                {
                    Console.WriteLine(_dataArray[i]);
                }
            }
        }
        public void Override(int data)
        {
            if (StackCheckFull() == true && data < _dataArray[_top])
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                while (!StackCheckEmpty() && data > _dataArray[_top])
                {
                    Pop();
                }
                Push(data);
            }
        }
    }
}
