using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace JoininMultithreading
{
    class Program
    {
        static void Dxc()
        {
            Console.WriteLine("Dxc training will start");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Training is started " + i);
            }
            Console.WriteLine("Training  is ended");
        }
        static void Alchemy()
        {
            Console.WriteLine("Alchemy start training");
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("Training is going on " + i);
            }
            Console.WriteLine("Training is ended by trainer");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread started");
            Thread T1 = new Thread(Dxc);//Bind the method with method object
            Thread T2 = new Thread(Alchemy);
            T1.Start();//run the method
            T2.Start();
            T1.Join();
            T2.Join();
            Console.WriteLine("Main Thread exiting");
            Console.ReadKey();
        }
    }
}
