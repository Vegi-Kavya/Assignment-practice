using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate
{
    public delegate void DisplayDelegate(float x,float y);
    public delegate int SumDelegate(int x, int y);
    public delegate bool GreetingDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            DisplayDelegate dd = delegate (float x,float y)
            {
                Console.WriteLine(x+y);
            };
            dd.Invoke(3.02f,4.2f);
            SumDelegate sd = delegate (int x,int y)
            {
                return x + y;
            };
            int result = sd.Invoke(60, 90);
            Console.WriteLine(result);
            GreetingDelegate gd = delegate (string name)
            {
                return true;
            };
            bool name1 = gd.Invoke("friends");
            Console.WriteLine(name1);
            Console.ReadKey();
        }
    }
}
