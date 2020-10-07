using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_delegate
{
    public delegate T MyDelegate<T>(T a,T b);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            MyDelegate<int> division=p.division;
            Console.WriteLine(division(80, 4));
            MyDelegate<string> concatination = p.Concatination;
            Console.WriteLine(concatination("tom&", "jerry"));
            Console.ReadKey();
        }
        public int division(int a, int b)
        {
            return a / b;

        }
        public string Concatination(string msg1, string msg2)
        {
            return msg1 + msg2;
        }
    }
}
