using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingleThread
{
    public delegate string Thread1Delegate();
    public delegate string Thread2Delegate();
    class Program
    {
        public static string Thread1()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Thread1 is started at the position " + i);

            }
            return "Thread1 is got exit";
        }
        public static string Thread2()
        {
            for (int i = 1; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Thread2 is waiting for 5 seconds");
                    Thread.Sleep(5000);

                }
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
            //Program obj1 = new Program();
            Thread1Delegate obj = new Thread1Delegate(Thread1);
            string result = obj.Invoke();
            //Console.WriteLine(result);
            Thread2Delegate obj1 = new Thread2Delegate(Thread2);
            string result1 = obj1.Invoke();
            Console.ReadKey();
        }
    }
}
