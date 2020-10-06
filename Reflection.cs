using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionsCsharp
{
    class Reflection
    {
        static void Main(string[] args)
        {
            Type T = typeof(int);
            Console.WriteLine("Attribute {0}",T.Attributes);
            Console.WriteLine("CustomAttributes {0}",T.CustomAttributes);
            Console.WriteLine("DeclaringType {0}",T.DeclaringType);
            Console.WriteLine("Name {0}", T.Name);
            Console.WriteLine("FullName {0}",T.FullName);
            Console.WriteLine("Namespace {0}", T.Namespace);
            Console.WriteLine("Basetype {0}", T.BaseType);
            string i = "kavya";
            System.ValueType type1 = i.GetTypeCode();
            System.Console.WriteLine(type1);
            System.ValueType type2 = i.IsNormalized();
            System.Console.WriteLine(type2);
            System.Type type = i.GetType();
            System.Console.WriteLine(type);
            //Example of uses reflections to obtain fullname of loaded assembly
            System.Reflection.Assembly info = typeof(System.String).Assembly;
            Console.WriteLine(info);
            Console.ReadKey();
        }
    }
}
