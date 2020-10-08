using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegatewithsixMethods
{
    //defining delegates
    public delegate string method1Delegate(string name);
    public delegate float method2Delegate(int a, int b, int c);
    public delegate void method3Delegate(string str);
    public delegate void method4Delegate(float a, float b);
    public delegate bool method5Delegate(int value);
    public delegate bool method6Delegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //initialize delegates
            method1Delegate obj1 = delegate (string name1)
            {
                return "Hello " + name1;
            };
            string name = obj1.Invoke("kavya");
            Console.WriteLine(name);
            method2Delegate obj2 =delegate(int a, int b, int c)
            {
                return a * b * c;
            };
            float result = obj2.Invoke(10, 20, 30);
            Console.WriteLine(result);
            method3Delegate obj3 = delegate(string str1)
            {
                Console.WriteLine("program is: " + str1);
            };
            obj3.Invoke("Delegate code");
            method4Delegate obj4 = delegate(float a,float b)
            {
                Console.WriteLine(a + b);
            };
            obj4.Invoke(10.32f, 20.56f);
            method5Delegate obj5 = delegate(int value)
            {
                if (value > 18)
                    return true;
                return false;
            };
            bool val = obj5.Invoke(30);
            Console.WriteLine(val);
            method6Delegate obj6 = delegate(string name1)
            {
                if (name1.Length < 5)
                    return true;
                return false;
            };
            bool str = obj6.Invoke("jerry");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
