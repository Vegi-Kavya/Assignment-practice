using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegatescsharp
{
    public delegate void MyDelegate(string msg); // declare a delegate
   
    class Delegate
    {
        static void MethodA(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Delegate p = new Delegate();
            // set target method
            MyDelegate del = new MyDelegate(MethodA);
            MyDelegate del1 = MethodA;
            // or set lambda expression 
            MyDelegate del3 = (string msg) => Console.WriteLine(msg);
            del.Invoke("Hello World!");
            del1("Hello World!!");
            del3("Hello World!!!");
            Console.ReadKey();
        }
       
    }
    
}
