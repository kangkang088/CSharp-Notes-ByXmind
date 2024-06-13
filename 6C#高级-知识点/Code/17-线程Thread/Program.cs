using System;
using System.Threading;

namespace _17_线程Thread
{
    internal class Program
    {
        public struct Data
        {
            public string message;
            public int age;
        }

        static void Test()
        {
            Console.WriteLine("Started");
            Thread.Sleep(1000);
            Console.WriteLine("Completed");
        }
        static void Download(Object o)
        {
            //string str = o as string;
            Data data =(Data)o;//null
            Console.WriteLine(data.age);
        }
        static void Main(string[] args)
        {
            //Thread t = new Thread(Test);
            //Thread t = new Thread(() => Console.WriteLine("Child Thread：" + Thread.CurrentThread.ManagedThreadId));
            //Thread t = new Thread(delegate () {

            //});
            //t.Start();
            //Console.WriteLine("Main completed:"+Thread.CurrentThread.ManagedThreadId);

            Data data = new Data();
            data.message = "";
            data.age = 12;

            Thread t = new Thread(Download);
            //t.Start("http://www.xxx.comn/xx/xx/xxx.mp4");
            t.Start(data);
            Console.WriteLine("Main completed:" + Thread.CurrentThread.ManagedThreadId);
        }
    }
}
