using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DeadlockinMultithreading
{
    class Program
    {
        public class Deadlock
        {
            static object firstLock = new object();
            static object secondLock = new object();
            static void ThreadJob()
            {
                Console.WriteLine("Locking firstLock");
                lock (firstLock)
                {
                    Console.WriteLine("Locked firstLock");
                    // Wait until we're fairly sure the first thread
                    // has grabbed secondLock
                    Thread.Sleep(1000);
                    Console.WriteLine("Locking secondLock");
                    lock (secondLock)
                    {
                        Console.WriteLine("Locked secondLock");
                    }
                    Console.WriteLine("Released secondLock");
                }
                Console.WriteLine("Released firstLock");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Main Thread Started");
                new Thread(new ThreadStart(ThreadJob)).Start();
                // Wait until we're fairly sure the other thread
                // has grabbed firstLock
                Thread.Sleep(500);
                Console.WriteLine("Locking secondLock");
                lock (secondLock)
                {
                    Console.WriteLine("Locked secondLock");
                    Console.WriteLine("Locking firstLock");
                    lock (firstLock)
                    {
                        Console.WriteLine("Locked firstLock");
                    }
                    Console.WriteLine("Released firstLock");
                }
                Console.WriteLine("Released secondLock");
                Console.ReadKey();
            }
        }
    }
}
