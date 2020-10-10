using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LocksinMultiThreading
{
    class Locks
    {
        public void Dxc()
        {
            lock (this)//is used to lock other thread where the current thread is sleeping/long time to response
            {
                Console.Write("Dxc Provide Training on ");
                Thread.Sleep(5000);
                Console.WriteLine("Csharp programming");
                Console.WriteLine();
            }
        }
        public void Alchemy()
        {
            lock (this)
            {
                Console.Write("Alchemy Solutions giving training on ");
                Console.WriteLine("Csharp programming");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Locks obj = new Locks();
            Thread t1 = new Thread(obj.Dxc);
            Thread t2 = new Thread(obj.Alchemy);
            Thread t3 = new Thread(obj.Dxc);
            Thread t4 = new Thread(obj.Alchemy);
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            Console.ReadKey();
        }
    }
}
