using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SortedList program");
            SortedList<int, string> s = new SortedList<int, string>();
            Console.WriteLine("The elements in sortedlist are:");
            s.Add(15, "kavya");
            s.Add(2, "samyu");
            s.Add(13, "neelu");
            s.Add(4, "jyothirmayee");
            s.Add(12, "vasantha");
            foreach (KeyValuePair<int, string> x in s)
            {
                Console.WriteLine("The elements are: " + x);
            }
            Console.WriteLine("The removed element is: " + s.Remove(12));
            Console.WriteLine("The removed element is: " + s.Remove(1));
            Console.WriteLine("The elements in dictionary after remove operation are:");
            foreach (KeyValuePair<int, string> x in s)
            {
                Console.WriteLine("The elements are: " + x);
            }
            Console.WriteLine("The elements exist in dictionary are: " + s.ContainsKey(4));
            Console.WriteLine("The elements exist in dictionary are: " + s.ContainsValue("samyu"));
            Console.ReadKey();
        }
    }
}
