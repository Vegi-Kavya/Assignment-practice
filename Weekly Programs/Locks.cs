using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Locks
{
    class Locks
    {
        public void Method1()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Hi everyone");
                    Thread.Sleep(4000);
                }
            }
        }
        public void Method2()
        {
            lock (this)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Have a nice day");
                }
            }
        }
        static void Main(string[] args)
        {
            Locks p = new Locks();
            Thread t1 = new Thread(p.Method1);
            Thread t2 = new Thread(p.Method2);
            p.Method1();
            p.Method2();
            t1.Start();
            t2.Start();
            Console.ReadKey();
        }
    }
}
