using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{
    public delegate void MyDelegate(string msg);
    class ClassA
    {
        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

    class ClassB
    {
        public  static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
    class Delegate1
    {
        static void Main(string[] args)
        {
            ClassA obj = new ClassA();
            MyDelegate del = new MyDelegate(ClassA.MethodA);
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
            Console.ReadKey();
        }
    }
    
}
