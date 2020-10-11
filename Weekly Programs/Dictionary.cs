using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary program");
            Dictionary<int, string> d = new Dictionary<int, string>();
            Console.WriteLine("The elements in dictionary are:");
            d.Add(1, "kavya");
            d.Add(2, "samyu");
            d.Add(3, "neelu");
            d.Add(4, "jyothirmayee");
            d.Add(5, "vasantha");
            foreach(KeyValuePair<int,string> x in d)
            {
                Console.WriteLine("The elements are: " + x);
            }
            Console.WriteLine("The removed element is: " + d.Remove(5));
            Console.WriteLine("The removed element is: " + d.Remove(1));
            Console.WriteLine("The elements in dictionary after remove operation are:");
            foreach (KeyValuePair<int, string> x in d)
            {
                Console.WriteLine("The elements are: " + x);
            }
            Console.WriteLine("The elements exist in dictionary are: "+d.ContainsKey(4));
            Console.WriteLine("The elements exist in dictionary are: " + d.ContainsValue("samyu"));
            Console.ReadKey();
        }
    }
}
