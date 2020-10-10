using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace semaphoreincsharp
{
    class semaphore
    {
        public static Semaphore s = new Semaphore(2,3);
        static void Main(string[] args)
        {
            for (int i= 0;i< 10; i++)
            {
                Thread obj=new Thread(new ThreadStart(PerformsomeWork));
                obj.Name = "ThreadName"+i;
                obj.Start();
            }
            Console.ReadKey();
        }
        public static void PerformsomeWork()
        {
            s.WaitOne();
            Console.WriteLine("Thread {0} is inside critical section", Thread.CurrentThread.Name);
            Thread.Sleep(5000);
            s.Release();
        }
    }
}
