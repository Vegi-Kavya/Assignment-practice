using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingleThreading
{
    class Program
    {
        public string Thread1()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Thread1 is waiting for 5 seconds");
                    Thread.Sleep(5000);

                }
                Console.WriteLine("Thread1 is started at the position " + i);

            }
            return "Thread1 is got exit";
        }
        public string Thread2()
        {
            for (int i = 1; i < 10; i++)
            {
                
                Console.WriteLine("Thread2 is started at the position " + i);

            }

            return "Thread2 is got exit ";
        }
        public static string Thread3()
        {
            return "Thread3 is started";
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Thread T = new Thread(delegate ()
            {
                Console.WriteLine(p.Thread1());
            });
            T.Start();
            T.Join();
            Thread T1 = new Thread(delegate ()
            {
                Console.WriteLine(p.Thread2());
            });
            T1.Start();
            Console.ReadKey();
        }
    }
}
