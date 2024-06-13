using System;
using System.Threading;

namespace _20_线程的优先级
{
    internal class Program
    {
        static void A()
        {
            while (true)
            {
                Console.Write("A");
            }
        }
        static void B()
        {
            while (true)
            {
                Console.Write("B");
            }
        }

        static void Main(string[] args)
        {
            Thread a = new Thread(A);
            Thread b = new Thread(B);

            //a.Priority = ThreadPriority.Highest;
            //b.Priority = ThreadPriority.Lowest;

            //a.Start();
            b.Start();


        }
    }
}
