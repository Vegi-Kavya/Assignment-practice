using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue Program is");
            Queue<string> q = new Queue<string>();
            Console.WriteLine("The elements in queue are:");
            q.Enqueue("kavya");
            q.Enqueue("samyu");
            q.Enqueue("neelu");
            q.Enqueue("jyothirmayee");
            q.Enqueue("vasantha");
            q.Enqueue("haritha");
            foreach(string x in q)
            {
                Console.WriteLine("The elemets are: " + x);
            }
            Console.WriteLine("The elements after dequeue operation is:");
            Console.WriteLine("The dequeued element is: "+q.Dequeue());
            Console.WriteLine("The dequeued element is: " + q.Dequeue());
            Console.WriteLine("The elements after dequeue  operation are:");
            foreach (string x in q)
            {
                Console.WriteLine("The elemets are: " + x);
            }
            Console.WriteLine("The elements exist in queue is: "+q.Contains("neelu"));
            Console.WriteLine("The ppek elements in queue is: "+q.Peek());
            Console.ReadKey();
        }
    }
}
