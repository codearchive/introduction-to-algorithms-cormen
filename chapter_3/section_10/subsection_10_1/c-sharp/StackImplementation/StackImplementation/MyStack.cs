using System;

namespace StackImplementation
{
    public class MyStack
    {
        private const int Size = 3;
        private int[] _arr;
        private int _capacity;
        private int _top;

        public MyStack(int size = Size)
        {
            _arr = new int[size];
            _capacity = size;
            _top = -1;
        }

        public void Push(int x)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
            }
            else
            {
                Console.WriteLine($"Insertion {x}");
                _arr[++_top] = x;
            }
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine($"Removing {Peek()}");
                return _arr[_top--];
            }
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                return _arr[_top];
            }
        }

        public int GetSize()
        {
            return _top + 1;
        }

        public bool IsEmpty()
        {
            return _top == -1;
        }

        public bool IsFull()
        {
            return _top == _capacity - 1;
        }
    }
}
