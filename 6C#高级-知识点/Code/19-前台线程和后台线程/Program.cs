using System;
using System.Threading;

namespace _19_前台线程和后台线程
{
    internal class Program
    {
        static void Main()
        {
            var t1 = new Thread(ThreadMain) { IsBackground = true };
            t1.Start();
            Console.WriteLine("Main thread ending now.");
            t1.Abort();

            Student student = new Student(20,"战三");
            Student student2 = new Student() {Age=15,Name="Micheal"};
        }
        static void ThreadMain() { 
            Console.WriteLine("Thread +" + Thread.CurrentThread.Name + " started"); 
            Thread.Sleep(3000); 
            Console.WriteLine("Thread +" + Thread.CurrentThread.Name + " end"); 
        }
    }
}