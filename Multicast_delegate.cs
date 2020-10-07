using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_delegate
{
    public delegate void MyDelegate(int a, int b);
    //public delegate void mulDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            MyDelegate sd = program1.sum;
            MyDelegate md = program2.mul;
            MyDelegate sm = sd + md;
            sm(20,100);
            MyDelegate ld = (int a, int b) => Console.WriteLine("Lambda Expression: {0}", a + b);
            sm = sm + ld;
            sm(20, 40);
            sm -= md;
            sm(30, 5);
            sm -= sd;
            sm(10, 10);
            Console.ReadKey();
        }
    }
    class program1
    {
        public static void sum(int a,int b)
        {
            Console.WriteLine("sum is: {0} ", a + b);
        }
    }
    class program2
    {
        public static void mul(int a, int b)
        {
            Console.WriteLine("mul is: {0}", a * b);
        }
    }
}
