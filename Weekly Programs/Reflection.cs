using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = typeof(double);
            Console.WriteLine("Name {0}", T.Name);
            Console.WriteLine("FullName {0}", T.FullName);
            Console.WriteLine("Namespace {0}", T.Namespace);
            Console.WriteLine("Basetype {0}", T.BaseType);
            double k = 23.56789;
            System.Type type = k.GetType();
            System.Console.WriteLine(type);
            System.Reflection.Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}
