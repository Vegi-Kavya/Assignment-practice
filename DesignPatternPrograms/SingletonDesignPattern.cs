using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    class SingletonDesignPattern
    {
        public class mytext
        {
            private static mytext kavya = new mytext();
            private mytext() { }
            public static mytext example
            {
                get { return kavya; }
            }
            public void Something()//method checking whether instance working or not
            {
                Console.WriteLine("mytext is working");
            }
        }
        
        static void Main(string[] args)
        {
            MySingleton Obj = MySingleton.Instance;
            Obj.DoSomething();
            MySingleton Obj1 = MySingleton.World;
            Obj1.Text();
            mytext Obj2 = mytext.example;
            Obj2.Something();
            Console.ReadKey();
        }
    }
    public class MySingleton//Mysingleton class ==> this CLASS  has only one instance
    {
        private static MySingleton instance = new MySingleton();//single instance created for the class":MysINGLETON
        private MySingleton() { }//methood instance to the class mysingleton
        public static MySingleton Instance//trying to fingd whether instance created or not
        {
            get { return instance; }
        }
        public static MySingleton World//trying to fingd whether instance created or not
        {
            get { return instance; }
        }
        public void DoSomething()//method checking whether instance working or not
        {
            Console.WriteLine("Singleton is working");
        }
        public void Text()//method checking whether instance working or not
        {
            Console.WriteLine("Object/Instance for Singleton always remains one");
        }
    }
}
