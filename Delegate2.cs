using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    public delegate void SumDelegate(int a, int b);
    public delegate void DivDelegate(int a, int b);
    class Delegate2
    {
        static void Main(string[] args)
        {
            SumDelegate sd = new SumDelegate(program.Sum);
            sd(500, 600);
            DivDelegate dd = new DivDelegate(program1.Division);
            dd(8, 2);
            Console.ReadKey();
        }
    }
    class program
    {
        public static void Sum(int a, int b)
        {
            Console.WriteLine("sum is: {0}", a + b);
        }
    }
    class program1
    {
        public static void Division(int a, int b)
        {
            Console.WriteLine("Division is: {0}", a / b);
        }
    }
}
