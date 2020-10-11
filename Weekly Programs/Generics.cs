using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Name<T>
    {
        T name;
        public Name(T kavya)
        {
            this.name = kavya;
        }
        public void Method()
        {
            Console.WriteLine("You are " + this.name);
        }
    }
    class CheckName<T>
    {
        T data;
        public CheckName(T check)
        {
            this.data = check;
        }
        public void write()
        {
            Console.WriteLine("Your friend name is: " + this.data);
        }
    }
    class Generics
    {
        static void Main(string[] args)
        {
            Name<string> result1 = new Name<string>("kavya");
            CheckName<string> result = new CheckName<string>("jerry");
            result.write();
            result1.Method();
            Console.ReadKey();
        }
    }
}
