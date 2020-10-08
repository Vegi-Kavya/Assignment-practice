﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class LambdaExpression
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine("the elements of list are");
            foreach (var val in num)
            {
                Console.WriteLine("{0}", val);
            }
            Console.WriteLine("multiplied by 2 in each number in list");
            var result = num.Select(x => 2 * x);
            foreach (var value in result)
            {
                Console.WriteLine("{0}", value);
            }
            Console.WriteLine("sum with 100 in each number in list");
            var result1 = num.Select(x => x + 100);
            foreach (var value in result1)
            {
                Console.WriteLine("{0}", value);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
