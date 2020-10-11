﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    public delegate void DisplayDelegate(float x,float y);
    public delegate int SumDelegate(int x, int y);
    public delegate bool GreetingDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            DisplayDelegate dd =(x,y)=>
            {
                Console.WriteLine(x+y);
            };
            dd.Invoke(3.02f,6.78f);
            SumDelegate sd = (x,y)=>
            {
                return x + y;
            };
            int result = sd.Invoke(60, 90);
            Console.WriteLine(result);
            GreetingDelegate gd = name =>
            {
                return true;
            };
            bool name1 = gd.Invoke("friends");
            Console.WriteLine(name1);
            Console.ReadKey();
        }
    }
}
