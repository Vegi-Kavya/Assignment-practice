using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    
    class Program
    {
        public  string Thread1()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Thread1 is waiting for 2 seconds");
                    Thread.Sleep(2000);
                }
                Console.WriteLine( "Thread1 is started at the position "+i);
            }
            return "Thread1 got exit";
        }
        public string Thread2()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Thread2 is waiting for 5 seconds");
                    Thread.Sleep(5000);
                }
                Console.WriteLine( "Thread2 is started at the position "+i);
            }

            return "Thread2 got exit ";
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Thread T1 = new Thread(delegate ()
              {
                  Console.WriteLine(obj.Thread1());
  
              });
            T1.Start();
            Thread T2 = new Thread(delegate ()
            {
                Console.WriteLine(obj.Thread2());

            });
            T2.Start();
            Console.ReadKey();
        }
    
    }
}
