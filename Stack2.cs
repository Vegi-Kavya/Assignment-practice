using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack2
{
    class Stack2
    {
        static void Main(string[] args)
        {
            Stack<Int32> s = new Stack<Int32>();
            s.Push(2);
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(2));
            s.Push(4);
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(4));
            s.Push(6);
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(6));
            s.Push(8);
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(8));
            s.Push(10);
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(10));
            Console.WriteLine("The elements in stack are:");
            foreach (int x in s)
            {
                Console.WriteLine("elements of stack are:" + x);
            }
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(10));
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(8));
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(6));
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(4));
            Console.WriteLine("pop element of stack is:" + s.Pop());
            Console.WriteLine("The no.of elements in stack are:" + s.Count());
            Console.WriteLine("The elements exist in stack is:" + s.Contains(2));
            Console.WriteLine("The elements in stack are:");
            foreach (int x in s)
            {
                Console.WriteLine("elements of stack are:" + x);
            }
            Console.ReadKey();
        }
    }
}
