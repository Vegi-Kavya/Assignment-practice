using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MulDelegate(int a, int b);
    class Delegates
    {
        public void Multiply(int a,int b)
        {
            Console.WriteLine(a * b);
            
        }
        static void Main(string[] args)
        {
            Delegates obj = new Delegates();
            MulDelegate Md = new MulDelegate(obj.Multiply);
            MulDelegate Muld = (int a,int b)=>Console.WriteLine(a*b);
            Md(20, 5);
            Muld(6, 8);
            Console.ReadKey();
        }
    }
}
