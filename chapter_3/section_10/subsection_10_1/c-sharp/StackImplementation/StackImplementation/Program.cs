using System;

namespace StackImplementation
{
    class Program
    {
        static void Main()
        {
            MyStack stack = new MyStack();

            Console.WriteLine($"Is my stack empty?\n\t{stack.IsEmpty()}");
            stack.Push(10);
            Console.WriteLine($"Is my stack empty?\n\t{stack.IsEmpty()}");
            stack.Push(20);
            stack.Pop();
            Console.WriteLine($"Stack size is: {stack.GetSize()}");
            Console.WriteLine($"Is my stack full?\n\t{stack.IsFull()}");
            stack.Push(30);
            stack.Push(40);
            Console.WriteLine($"Is my stack full?\n\t{stack.IsFull()}");
            Console.ReadLine();
        }
    }
}
