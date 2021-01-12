//SINGLE THREADED MODULE
//until and unless the current thread executed completely the other thread will in idle time
using System;
using System.Threading;
class Threaddemo{
	static void Thread1(){
	for(int i=1;i<15;i++){
	Console.WriteLine("Thread1 is started");
	Console.WriteLine("Thread1 is started at the position: "+i);
	}
	Console.WriteLine("Thread1 got exit");
	Console.WriteLine();	
	}
	static void Thread2(){
	for(int i=1;i<15;i++){	
	if(i==14){
	Console.WriteLine("Thread2 is sleeping for 14 seconds");
	Thread.Sleep(14000);//14000 means 14 seconds
	}
	Console.WriteLine("Thread2 is wake up after 5 seconds");
	Console.WriteLine("Thread2 is started");
	Console.WriteLine("Thread2 is started at the position: "+i);
	}
	Console.WriteLine("Thread2 got exit");
	Console.WriteLine();
	}
	static void Thread3(){
	for(int i=1;i<15;i++){
	Console.WriteLine("Thread3 is started");
	Console.WriteLine("Thread3 is started at the position: "+i);
	}
	Console.WriteLine("Thread3 got exit");
	Console.WriteLine();
	}
	static void Main(string[] args){
	//instantite the methods created
	Thread1();
	Thread2();
	Thread3();
	Console.WriteLine("Main thread executed all the threads from the program");
	}
}