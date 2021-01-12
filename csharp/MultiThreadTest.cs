using System;
using System.Threading;
class MultiThreadTest{
	static void Thread1(){
	for(int i=1;i<15;i++){
	Console.WriteLine("Thread1 is started at the position: "+i);
	}
	}
	static void Thread2(){
	for(int i=1;i<15;i++){
	if(i==10){
	Console.WriteLine("thread2 is sleeping for 10 seconds");
	Thread.Sleep(10000);
	}
	Console.WriteLine("Thread2 is started  at the position: "+i);
	}
	}
	static void Thread3(){
	for(int i=1;i<15;i++){
	Console.WriteLine("Thread3 is started at the position: "+i);
	}
	}
	static void Main(string[] args){
	Thread T1=new Thread(Thread1);//create child thread class w.r.to methods involved
	Thread T2=new Thread(Thread2);
	Thread T3=new Thread(Thread3);//one main thread 3 child threads
	Thread1();
	Thread2();
	Thread3();
	T1.Start();
	T2.Start();
	T3.Start();
	}
}

/*1.Whether all the threads are starting and exiting the loop
2.Shall we that all threads are executing will overlap?
time? who will provide this time?
sleep(),Start() who are response?
program os respond
*/