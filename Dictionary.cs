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
            Dictionary<string, string> mydictionary = new Dictionary<string, string>();
            //Add to insert elements
            mydictionary.Add("Category", "Men Collections");
            mydictionary.Add("Category1", "Women Collections");
            mydictionary.Add("Product Name", "Wrist Watch");
            mydictionary.Add("Product Name1", "Frock");
            Console.WriteLine("The elements in dictionary are:");
            foreach (KeyValuePair<string,string> dictionary in mydictionary)
            {
                Console.WriteLine("The elements in dictionary are:" + dictionary.Key + dictionary.Value);
            }
            Console.ReadKey();

        }
    }
}
