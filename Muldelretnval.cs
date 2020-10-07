using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicastdelegateretnval
{
    public delegate int Mydelegate();
    class Program
    {
        static void Main(string[] args)
        {
            delegate1 d = new delegate1();
            Mydelegate md1 = new Mydelegate(d.sum);
            Mydelegate md2 = new Mydelegate(d.mul);
            Mydelegate md=md1+md2;
            Console.WriteLine(md());
            Console.ReadKey();
        }
    }
    class delegate1
    {
        public int sum()
        {
            return 50;
        }
        public int mul()
        {
            return 150;
        }
    }
}
