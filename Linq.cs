using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 23, 45, 67, 92, 13, 56, 25, 42 };
            var brr=from i in arr where i>40 orderby i descending select i;
            var brr1 = from i in arr where i > 40 orderby i ascending select i;
            foreach (int x in brr)
            {
                Console.WriteLine(x + " ");
            }
            foreach (int x in brr1)
            {
                Console.WriteLine(x + " ");
            }
            Console.ReadKey();
        }
    }
}
