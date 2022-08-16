using System;

namespace Stack_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListStack");
            Stack stack = new Stack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Display();
            stack.peek();
            stack.pop();
            stack.Display();
            stack.isEmpty();
            Console.ReadLine();
        }
    }
}
