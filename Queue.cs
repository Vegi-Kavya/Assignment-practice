using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Queue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");
            Queue<Int32> myqueue = new Queue<int>();
            myqueue.Enqueue(2);
            myqueue.Enqueue(4);
            myqueue.Enqueue(6);
            myqueue.Enqueue(8);
            myqueue.Enqueue(10);
            myqueue.Enqueue(12);
            myqueue.Enqueue(14);
            myqueue.Enqueue(16);
            myqueue.Enqueue(18);
            myqueue.Enqueue(20);
            Console.WriteLine("elements in queue are:");
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            Console.WriteLine("After dequeue elements from queue"+ myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("The left of elements in queue are:");
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            myqueue.Enqueue(2);
            myqueue.Enqueue(4);
            myqueue.Enqueue(6);
            myqueue.Enqueue(8);
            myqueue.Enqueue(10);
            myqueue.Enqueue(12);
            Console.WriteLine("inserting elements into queue");
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            myqueue.Enqueue(14);
            myqueue.Enqueue(16);
            myqueue.Enqueue(18);
            myqueue.Enqueue(20);
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            myqueue.Enqueue(2);
            myqueue.Enqueue(4);
            myqueue.Enqueue(6);
            myqueue.Enqueue(8);
            Console.WriteLine("inserting elements into queue");
            Console.WriteLine("After dequeue elements from queue" + myqueue.Dequeue());
            foreach (int queue in myqueue)
            {
                Console.WriteLine("elements are:" + queue);
            }
            Console.WriteLine("The peek element of the queue is:{0}", myqueue.Peek());
            Console.WriteLine("The no.of element in the queue is:{0}", myqueue.Count());
            Console.WriteLine("The element exist in the queue is:{0}", myqueue.Contains(20));
            Console.WriteLine("The element exist in the queue is:{0}", myqueue.Contains(12));
            Console.ReadKey();
        }
    }
}
