using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackHomework
{
    public class MyStack
    {
        public int top;
        public int size;
        public int[] dataArray;
        public MyStack(int size)
        {
            top = -1;
            this.size = size;
            dataArray = new int[size];
        }
        public void Push(int data)
        {
            if (CheckStackFull())
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                top++;
                dataArray[top] = data;

            }
        }
        public bool CheckStackFull()
        {
            if (top == size - 1)
            {
                return true;
            }
            return false;
        }
        public bool CheckStackEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public int Pop()
        {
            if (CheckStackEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                top--;
                return dataArray[top + 1];
            }
        }
        public void Print()
        {
            if (CheckStackEmpty())
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("The stack is: ");
                for (int i = top; i > -1; i--)
                {
                    Console.WriteLine(dataArray[i]);
                }
            }
        }
        public void Delete(int deletedData)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < size; i++)
            {
                if (dataArray[i] != deletedData)
                {
                    Pop();
                    list.Add(dataArray[i]);
                }
            }
            Pop();
            foreach (int item in list)
            {
                Push(item);
            }
        }
        public void Swap()
        {
            List<int> list = new List<int>();
            int x = dataArray[0];
            int y = dataArray[top];
            for (int i = 0; i < size; i++)
            {
                Pop();
                list.Add(dataArray[i]);
            }
            Push(y);
            for (int j = 1; j < list.Count-1; j++)
            {
                Push(list[j]);
            }
            
            Push(x);
        }
    }
}
