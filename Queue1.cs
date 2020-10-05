using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue1
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue<Int32> q = new Queue<Int32>();
            q.Enqueue(2);
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(2));
            q.Enqueue(4);
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(4));
            q.Enqueue(6);
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(6));
            q.Enqueue(8);
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(8));
            q.Enqueue(10);
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(10));
            Console.WriteLine("The list of elements in queue are:");
            foreach (int x in q)
            {
                Console.WriteLine("elements of queue are:" + x);
            }
            Console.WriteLine("pop element of queue is:" + q.Dequeue());
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(2));
            Console.WriteLine("pop element of queue is:" + q.Dequeue());
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(4));
            Console.WriteLine("pop element of stack is:" + q.Dequeue());
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(6));
            Console.WriteLine("pop element of stack is:" + q.Dequeue());
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(8));
            Console.WriteLine("pop element of queue is:" + q.Dequeue());
            Console.WriteLine("The no.of elements in queue are:" + q.Count());
            Console.WriteLine("The elements exist in queue is:" + q.Contains(10));
            Console.WriteLine("The list of elements in queue are:");
            foreach (int x in q)
            {
                Console.WriteLine("elements of queue are:" + x);
            }
            Console.ReadKey();
        }
    }
}
