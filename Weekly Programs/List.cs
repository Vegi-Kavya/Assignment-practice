using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Program");
            List<int> li = new List<int>();
            Console.WriteLine("The elements in list are:");
            li.Add(16);
            li.Add(2);
            li.Add(31);
            li.Add(4);
            li.Add(67);
            li.Add(56);
            li.Insert(2, 74);
            foreach (int x in li)
            {
                Console.WriteLine("The elements are: {0}" ,x);
            }
            Console.WriteLine("Removed element from list is "+li.Remove(2));
            Console.WriteLine("Removed element from list is " + li.Remove(5));
            foreach (int x in li)
            {
                Console.WriteLine("The elements are: {0}" , x);
            }
            Console.WriteLine("The elements exist in list are: "+li.Contains(4));
            Console.WriteLine("The elements in list are: "+li.Count);
            Console.ReadKey();
        }
    }
}
