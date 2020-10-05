using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            Console.WriteLine("List created");
            foreach (var li in list)
            {
                Console.WriteLine("The elements of list are:" + li);
            }
            //contains
            Console.WriteLine("the element exist in list or not:");
            Console.WriteLine(list.Contains(10));
            Console.WriteLine(list.Contains(70));
            Console.WriteLine(list.Contains(30));
            //Accessing list element by index
            Console.WriteLine("The list of 1st index is:" + list[0]);
            Console.WriteLine("The list of 2nd index is:" + list[1]);
            Console.WriteLine("The list of 3rd index is:" + list[2]);
            Console.WriteLine("The list of 4th index is:" + list[3]);
            Console.WriteLine("The list of 5th index is:" + list[4]);
            //insert(position/index,value)
            list.Insert(5,60);
            list.Insert(6, 70);
            Console.WriteLine("The list of 6th index is:" + list[5]);
            Console.WriteLine("The list of 7th index is:" + list[6]);
            //Remove
            Console.WriteLine("checking for remove method");
            Console.WriteLine(list.Remove(50));
            Console.WriteLine(list.Remove(70));
            Console.ReadKey();
        }
    }
}
