using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraint
{
    class General<T> where T : Exception
    {
        public void write()
        {
            Console.WriteLine("Data exception");
        }
    }
    class java<T> where T : Exception
    {
        public void Throw()
        {
            Console.WriteLine("Index out of range Exception ");
        }
    }
    class Method<T> where T : Exception
    {
        public void Throws()
        {
            Console.WriteLine("Format Exception ");
        }
    }
    class GenericConstraint
    {
        static void Main(string[] args)
        {
            General<DataException> general = new General<DataException>();
            java<IndexOutOfRangeException> test = new java<IndexOutOfRangeException>();
            Method<FormatException> method = new Method<FormatException>();
            general.write();
            test.Throw();
            method.Throws();
            Console.ReadKey();
        }
    }
}
