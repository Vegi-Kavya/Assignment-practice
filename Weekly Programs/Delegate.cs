using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void DisplayDelegate(float x,float y);
    public delegate int SumDelegate(int x, int y);
    public delegate bool GreetingDelegate(string str);
    class Program
    {
        public static void Display(float x,float y)
        {
            Console.WriteLine(x+y);
        }
        public static int Sum(int x,int y)
        {
            return x + y;
        }
        public bool Greeting(string name)
        {
            return true;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            DisplayDelegate dd = new DisplayDelegate(Display);
            dd.Invoke(3.42f,5.6f);
            SumDelegate sd = new SumDelegate(Sum);
            int result=sd.Invoke(60, 90);
            Console.WriteLine(result);
            GreetingDelegate gd = new GreetingDelegate(p.Greeting);
            bool name = gd.Invoke("kavya");
            Console.WriteLine(name);
            Console.ReadKey();
        }
    }
}
