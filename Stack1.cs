using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack1
{
    class Stack1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
            Stack<Int32> s = new Stack<Int32>();
            s.Push(2);
            s.Push(4);
            s.Push(6);
            s.Push(8);
            s.Push(10);
            s.Push(12);
            s.Push(14);
            s.Push(16);
            s.Push(18);
            s.Push(20);
            Console.WriteLine("The elements after push are:");
            foreach (int x in s)
            {
                Console.WriteLine("elements of stack are:" + x);
            }
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("The peek element of stack is:" + s.Peek());
            Console.WriteLine("The elements left in stack are");
            foreach (int x in s)
            {
                Console.WriteLine("elements of stack are:" + x);
            }
            Console.ReadKey();
        }
    }
}
