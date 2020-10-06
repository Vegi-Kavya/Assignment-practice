using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class example1<T>
    {
        T value;
        public example1(T check1)
        {
            this.value = check1;
        }
        public void read()
        {
            Console.WriteLine("The value is: " + this.value);
        }
        public void write()
        {
            Console.WriteLine("The value is " + this.value);
        }
    }
    
    class GenericClass
    {
        static void Main(string[] args)
        {
            example1<int> res = new example1<int>(1500);
            example1<string> res1 = new example1<string>("depend on your behaviour");
            res.read();
            res1.write();
            Console.ReadKey();
        }
    }
}
