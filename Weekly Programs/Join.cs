using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Joins
{
    class Join
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
            Console.WriteLine("Main thread started");
            Join p = new Join();
            Thread t1 = new Thread(p.Method1);
            Thread t2 = new Thread(p.Method2);
            p.Method2();
            p.Method1();
            p.Method2();
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main thread exiting");
            Console.ReadKey();
        }
    }
}
