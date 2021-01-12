/* by default every application is single thread module*/
using System;
using System.Threading;
class Threaddemo{
static void Main(string[] args){ 
Thread T=Thread.CurrentThread;
T.Name="thread created manually by kavya";
Console.WriteLine(Thread.CurrentThread.Name);

//this is also a thread
Console.WriteLine("Hello to the world from threading module");
Console.ReadLine();
}
}