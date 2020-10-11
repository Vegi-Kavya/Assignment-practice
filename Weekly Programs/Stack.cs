using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack Program");
            Stack<int> s = new Stack<int>();
            Console.WriteLine("The elements of stack are: ");
            s.Push(20);
            s.Push(15);
            s.Push(10);
            s.Push(5);
            s.Push(1);
            foreach (int x in s)
            {
                Console.WriteLine("The elwments are: " + x);
            }
            Console.WriteLine("The popped element is: " + s.Pop());
            Console.WriteLine("The popped element is: " + s.Pop());
            Console.WriteLine("the elements in stack after pop operation:");
            foreach (int x in s)
            {
                Console.WriteLine("The elwments are: " + x);
            }
            Console.WriteLine("The peek element is: " + s.Peek());
            Console.WriteLine("The element exist in stack: " + s.Contains(15));
            Console.ReadLine();

        }
    }
}
