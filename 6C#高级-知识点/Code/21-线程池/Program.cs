using System;
using System.Threading;

namespace _21_线程池
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for(int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(Download);
            }
            Thread.Sleep(5000);
        }

        static void Download(Object state)
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("DownLoading ...:"+Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            }
        }
    }
}
