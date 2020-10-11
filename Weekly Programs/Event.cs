using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public delegate void addnum1();
    public class ProcessBusinessLogic
    {
        public event addnum1 ProcessCompleted;
        public void ProcessStart()
        {
            Console.WriteLine("Process started");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted.Invoke();
        }
    }
    class Event
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic PBL = new ProcessBusinessLogic();
            PBL.ProcessCompleted += PBL_ProcessCompleted;
            PBL.ProcessStart();
            Console.ReadKey();
        }
        public static void PBL_ProcessCompleted()
        {
            Console.WriteLine("Process completed");
        }
    }
}
