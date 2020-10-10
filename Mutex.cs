using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Mutexincsharp
{
    class Program
    {
        private static Mutex mutex = new Mutex();
        private const int numhits = 1;
        private const int numThreads = 4;
        private static void ThreadProcess()
        {
            for (int i = 0; i < numhits; i++)
            {
                UseCsharpcorner();
            }
        }
        private static void UseCsharpcorner()
        {
            mutex.WaitOne();   // Wait until it is safe to enter.  
            Console.WriteLine("{0} has entered in the room",
                Thread.CurrentThread.Name);
            // Place code to access non-reentrant resources here.  
            Thread.Sleep(500);    // Wait until it is safe to enter.  
            Console.WriteLine("{0} is leaving the room\r\n",
                Thread.CurrentThread.Name);
            mutex.ReleaseMutex();    // Release the Mutex.
        }
        static void Main(string[] args)
        {
             for (int i = 0; i < numThreads; i++)
             {
                  Thread thread = new Thread(new ThreadStart(ThreadProcess));
                  thread.Name = String.Format("Thread{0}", i + 1);
                  thread.Start();
             }
             Console.ReadKey();
        }
        
    }
}
