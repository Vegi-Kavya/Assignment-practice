using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class DemoOfSingleton
    {
        public sealed class Calculate
        {
            private Calculate() { }
            private static Calculate instance = null;
            public static Calculate Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Calculate();
                    }
                    return instance;
                }
            }
            public double ValueOne { get; set; }
            public double ValueTwo { get; set; }
            public double Addition()
            {
                return ValueOne + ValueTwo;
            }
            public double Substraction()
            {
                return ValueOne -ValueTwo;
            }
            public double Multiplication()
            {
                return ValueOne * ValueTwo;
            }
            public double Division()
            {
                return ValueOne / ValueTwo;
            }
        }
        static void Main(String[] args)
        {
            Calculate obj = Calculate.Instance;
            Calculate.Instance.ValueOne = 10.8;
            Calculate.Instance.ValueTwo = 10.753;
            Console.WriteLine("Addition is: " + Calculate.Instance.Addition());
            Console.WriteLine("Substraction is: " + Calculate.Instance.Substraction());
            Console.WriteLine("Multiplication is: " + Calculate.Instance.Multiplication());
            Console.WriteLine("Division is: " + Calculate.Instance.Division());
            Console.ReadKey();
        }
    }
}
