using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue
    {
        int _front; //default private 
        int _rear;
        int[] _values;
        int _size;
        public Queue(int size)
        {
            _size = size;
            _values = new int[size];
            _rear = -1; //to make it [0] when we want to add or remove a value.          
            _front = -1;
        }
        public bool CheckEmpty()
        {
            return _rear == _front; //returns true if statement is satisfied.
        }
        public bool CheckFull()
        {
            return _size - 1 == _rear;
        }
        public void EnQueue(int data) //method for adding a new member
        {
            if (CheckFull())
            {
                Console.WriteLine("Queue is full.");
            }
            else
            {
                //_rear++; is equal to [++_rear]
                _values[++_rear] = data; 
            }
        }
        public int DeQueue()
        {
            if (CheckEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1; //return nothing
            }
            else
            {
                //_front++;
                return _values[++_front];
            }
        }
        public void EditQueue()
        {
            for (int i = 0; i < _size - (_front +1) ; i++)
            {
                _values[i] = _values[i + _front + 1];
                _values[i + _front + 1] = 0;
            }
            _rear -= _front + 1;
            _front = -1;
        }
        public void Print()
        {
            if (CheckEmpty())
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = _front+1  ; i < _size ; i++) //front is currently -1
                {
                    Console.WriteLine(_values[i]);
                }
            }
        }
    }
}
