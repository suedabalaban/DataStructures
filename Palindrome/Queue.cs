using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Queue
    {
        int _front;
        int _rear;
        char[] _values;
        int _size;
        public Queue(int size)
        {
            _size = size;
            _values = new char[size];
            _front = -1;
            _rear = -1;
        }
        public bool CheckEmpty()
        {
            return _front == _rear;
        }
        public bool CheckFull()
        {
            return _rear == _size - 1;
        }
        public void EnQueue(char data)
        {
            if (CheckFull())
            {
                Console.WriteLine("Queue is full.");
            }
            else
            {
                _rear++;
                _values[_rear] = data;
            }
        }
        public char DeQueue()
        {
            if (CheckEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return (char)0;
            }
            else
            {
                _front++;
                return _values[_front];
            }
        }
        public void EditQueue()
        {
            for (int i = 0; i < _size - (_front +1); i++)
            {
                _values[i] = _values[i + _front + 1];
                _values[i + _front + 1] = (char) 0;
            }
            _rear = _rear - (_front + 1);
            _front = -1;
        }
        public void Print()
        {
            Console.WriteLine("QUEUE");
            if (CheckEmpty())
            {
                Console.WriteLine("Queue is empty.");
            }
            else
            { 
                for (int i = _front +1 ; i < _size; i++)
                {
                    Console.WriteLine(_values[i]);
                }
            }
        }
    }
}
