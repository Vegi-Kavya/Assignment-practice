using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class SingletonDP
    {
        static void Main(string[] args)
        {
            Mysingleton obj1 = Mysingleton.Instance;
            obj1.Check();
            mysingleton obj2 = new mysingleton.Instance1;
            obj2.write();
            Console.ReadKey();
        }
    }
    public sealed class Mysingleton
    {
        public void Check()
        {
            Console.WriteLine("if the instance be null the singleton design pattern will thread unsafe");
        }
        //private constructor
        private Mysingleton() { }
        private static Mysingleton instance = null;
        public static Mysingleton Instance
        {
            get
            {
                if (instance == null)//if instance found true then singleton design pattern will thread unsafe
                {
                    instance = new Mysingleton();
                }
                return instance;

            }
        }
    }
    public sealed class mysingleton
    {
        private mysingleton() { }
        private static readonly object find = new object();
        private static mysingleton instance = null;//find whether any of instance null
        private static mysingleton Instance1
        {
            get
            {
                lock (find)//lock the empty or null instance, so that it would not execute further
                               //because if instance found empty that no more thread safe!!!!!
                {
                    if (instance == null)
                    {
                         instance = new mysingleton();
                    }
                }
                return instance;
            }
        }
        public void write()
        {
            Console.WriteLine("We have locked the empty/null instance to make sure singletom ddesign pattern thread safe");
        }
    }
    
}
