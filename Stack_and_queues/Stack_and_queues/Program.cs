using System;

namespace Stack_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To LinkedListStack");
            Queue queue = new Queue();
            Console.WriteLine("\nLinkedList_Queue");
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Display();
            Console.ReadLine();
        }
    }
}
