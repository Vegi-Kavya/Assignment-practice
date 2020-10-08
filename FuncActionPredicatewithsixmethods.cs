using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionPredicatewithsixmethods
{

    class Program
    {
        static void Main(string[] args)
        {
            Func<string,string> obj1 = name1 => "Hello " + name1;
            string name = obj1.Invoke("kavya");
            Console.WriteLine(name);
            Func<int, int, int, int> obj2 = (a, b, c) => (a * b * c);
            float result = obj2.Invoke(10, 20, 30);
            Console.WriteLine(result);
            Action<string> obj3 = str1 => Console.WriteLine("program is: " + str1);
            obj3.Invoke("Delegate code");
            Action<float, float> obj4 = (a, b) => Console.WriteLine(a + b);
            obj4.Invoke(10.32f, 20.56f);
            Predicate<int> obj5 = value =>
            {
                if (value > 18)
                    return true;
                return false;
            };
            bool val = obj5.Invoke(30);
            Console.WriteLine(val);
            Predicate<string> obj6 = name1 =>
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
