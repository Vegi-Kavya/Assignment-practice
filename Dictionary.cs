﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mydictionary = new Dictionary<string, string>();
            //Add to insert elements
            mydictionary.Add("1", "Bangalore");
            mydictionary.Add("2", "Mumbai");
            mydictionary.Add("3", "Pune");
            mydictionary.Add("4", "Hyderabad");
            mydictionary.Add("5", "Chennai");
            mydictionary.Add("6", "Delhi");
            Console.WriteLine("The elements in dictionary are:");
            mydictionary["7"] = "Kolkatta";
            mydictionary["8"] = "Ahmedabad";
            mydictionary["9"] = "Noida";
            mydictionary["10"] = "Tiruvanantapuram";
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            //remove
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("10"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("9"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("8"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("7"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("6"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("5"));
            Console.WriteLine("the key-value pairs in dictionary are:");
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("After add elements into dictionary are:");
            mydictionary.Add("5", "Chennai");
            mydictionary.Add("6", "Delhi");
            mydictionary["7"] = "Kolkatta";
            mydictionary["8"] = "Ahmedabad";
            mydictionary["9"] = "Noida";
            mydictionary["10"] = "Tiruvanantapuram";
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("1"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("2"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("3"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("4"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("5"));
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("6"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("7"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("8"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("9"));
            Console.WriteLine("After add elements into dictionary are:");
            mydictionary.Add("1", "Bangalore");
            mydictionary.Add("2", "Mumbai");
            mydictionary.Add("3", "Pune");
            mydictionary.Add("4", "Hyderabad");
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("10"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("1"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("2"));
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("3"));
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("4"));
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("After add elements into dictionary are:");
            mydictionary.Add("1", "Bangalore");
            mydictionary.Add("2", "Mumbai");
            mydictionary.Add("3", "Pune");
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            Console.WriteLine("elements in dictionary after remove: " + mydictionary.Remove("1"));
            Console.WriteLine("After add elements into dictionary are:");
            foreach (KeyValuePair<string, string> dictionary in mydictionary)
            {
                Console.WriteLine("The element of dictionary are:" + dictionary.Key + " " + dictionary.Value);
            }
            //count
            Console.WriteLine("the no of elements present in dictionary: " + mydictionary.Count());
            Console.ReadKey();

        }
    }
}
