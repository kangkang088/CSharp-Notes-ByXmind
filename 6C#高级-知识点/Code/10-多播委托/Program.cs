using System;

namespace _10_多播委托
{
    internal class Program
    {
        private static void Test1()
        {
            Console.WriteLine("Test1");
        }
        private static void Test2()
        {
            Console.WriteLine("Test2");
        }
        static void Main(string[] args)
        {
            Action action1 = Test1;
            action1 += Test2;//action1 = action1 + Test2;
            //action1 += Test2;//action1 = action1 + Test2;


            //action1 -= Test1;
            //action1();
            Delegate[] delegates =  action1.GetInvocationList();
            foreach (Delegate d in delegates)
            {
                d.DynamicInvoke();
            }
        }
    }
}
