using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatewithsixmethods
{
    //defining delegates
    public delegate string method1Delegate(string name);
    public delegate float method2Delegate(int a,int b,int c);
    public delegate void method3Delegate(string str);
    public delegate void method4Delegate(float a,float b);
    public delegate bool method5Delegate(int value);
    public delegate bool method6Delegate(string name);
    class Program
    {
        public static string method1(string name)
        {
            return "Hello" + name;
        }
        public static float method2(int a,int b,int c)
        {
            return a * b * c;
        }
        public static void method3(string str)
        {
            Console.WriteLine("program is: " + str);
        }
        public static void method4(float a,float b)
        {
            Console.WriteLine(a+b);
        }
        public static bool method5(int value)
        {
            if (value > 18)
                return true;
            return false;
        }
        public static bool method6(string name)
        {
            if (name.Length < 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            //initialize delegates
            method1Delegate obj1 = new method1Delegate(method1);
            string name = obj1.Invoke("kavya");
            Console.WriteLine(name);
            method2Delegate obj2 = new method2Delegate(method2);
            float result = obj2.Invoke(10, 20, 30);
            Console.WriteLine(result);
            method3Delegate obj3 = new method3Delegate(method3);
            obj3.Invoke("Delegate code");
            method4Delegate obj4 = new method4Delegate(method4);
            obj4.Invoke(10.32f, 20.56f);
            method5Delegate obj5 = new method5Delegate(method5);
            bool val = obj5.Invoke(30);
            Console.WriteLine(val);
            method6Delegate obj6 = new method6Delegate(method6);
            bool str = obj6.Invoke("jerry");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
