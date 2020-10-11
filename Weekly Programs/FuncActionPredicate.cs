using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<float,float> dd = (x,y) =>
            {
                Console.WriteLine(x+y);
            };
            dd.Invoke(3.02f,6.78f);
            Func<int,int,int> sd = (x, y) =>
            {
                return x + y;
            };
            int result = sd.Invoke(60, 90);
            Console.WriteLine(result);
            Predicate<string> gd = name =>
            {
                return true;
            };
            bool name1 = gd.Invoke("friends");
            Console.WriteLine(name1);
            Console.ReadKey();
        }
    }
}
