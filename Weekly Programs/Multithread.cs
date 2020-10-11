﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class Multithread
    {
        public void Method1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hi everyone");
            }
        }
        public void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Have a nice day");
            }
        }
        static void Main(string[] args)
        {
            Multithread p = new Multithread();
            Thread t1 = new Thread(p.Method1);
            Thread t2 = new Thread(p.Method2);
            p.Method2();
            p.Method1();
            p.Method2();
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
