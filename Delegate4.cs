using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate4
{
    public delegate void Method1Delegate(string msg);
    //public delegate void Method2Delegate(string msg);
    class Program
    {
        static void Main(string[] args)
        {
            Method1Delegate md1 = new Method1Delegate(program1.method1);
            InvokeDelegate(md1);
            md1 = program2.method2;
            InvokeDelegate(md1);
            md1 = (string msg) => Console.WriteLine("lambda expression: "+msg);
            InvokeDelegate(md1);
            Console.ReadKey();
        }
        static void InvokeDelegate(Method1Delegate md1)
        {
                md1("invoke method");
        }
    }
    class program1
    {
        public static void method1(string message)
        {
            Console.WriteLine("This is Method1"+message);
        }
    }
    class program2
    {
        public static void method2(string message)
        {
            Console.WriteLine("This is Method2"+message);
        }
    }
}
