using System;

namespace Data_structures2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();

            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(11);

            System.Console.WriteLine(stack);

            int poppedElement;

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

            poppedElement = stack.Pop();
            System.Console.WriteLine($"poppedElement => {poppedElement}");
            System.Console.WriteLine(stack);

            int toppedElement;
            toppedElement = stack.Top();
            System.Console.WriteLine($"toppedElement => {toppedElement}");
            System.Console.WriteLine(stack);

            toppedElement = stack.Top();
            System.Console.WriteLine($"toppedElement => {toppedElement}");
            System.Console.WriteLine(stack);

            Queue queue = new Queue();

            queue.Enqueue(33);

            System.Console.WriteLine(queue);

            queue.Enqueue(33);
             System.Console.WriteLine(queue);

             System.Console.WriteLine($"queue.Front() => {queue.Front()}");
             System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");

             queue.Enqueue(12);
             queue.Enqueue(45);
             queue.Enqueue(10);
             queue.Enqueue(7);
             queue.Enqueue(89);

             System.Console.WriteLine(queue);

             System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");


            System.Console.WriteLine($"queue.Dequeue() => {queue.Dequeue()}");
            System.Console.WriteLine($"queue.Dequeue() => {queue.Dequeue()}");

            System.Console.WriteLine(queue);

            System.Console.WriteLine($"queue.Front() => {queue.Front()}");
            System.Console.WriteLine($"queue.Rear() => {queue.Rear()}");


        }
    }
}
