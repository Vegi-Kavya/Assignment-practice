using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateReturnValue
{
    public delegate void AddnumDelegate(int a,int b);
    public delegate void mulDelegate(int a, int b);
    public delegate void divDelegate(int a, int b);
    public delegate void HelloDelegate(string str);
    class Program
    {
        //public static void Addnum(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}
        static void Main(string[] args)
        {
            // AddnumDelegate obj = new AddnumDelegate(Addnum);
            AddnumDelegate obj1 = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            // obj.Invoke("Girls");
            // Console.WriteLine(obj.Invoke("Girls"));
            mulDelegate obj = delegate (int a, int b)
            {
                Console.WriteLine(a * b);
            };
            divDelegate obj2 = delegate (int a, int b)
            {
                Console.WriteLine(a / b);
            };
            HelloDelegate obj3 = delegate (string name)
            {
                Console.WriteLine("The name is: "+name);
            };
            obj1.Invoke(10, 20);
            obj.Invoke(15,30);
            obj2.Invoke(30,15);
            obj3.Invoke("kavya");
            Console.ReadKey();
        }
    }
}
