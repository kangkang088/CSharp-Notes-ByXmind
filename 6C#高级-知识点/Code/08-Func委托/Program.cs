using System;

namespace _08_Func委托
{
    internal class Program
    {
        private static string Test1()
        {
            return "siki";
        }
        private static string Test2(int x,double y)
        {
            return "siki" + x+y ;
        }
        static void Main(string[] args)
        {
            Func<string> f = Test1;
            Console.WriteLine(f());

            Func<int, double, string> f2 = Test2;
            Console.WriteLine(f2(3, 4));
        }
    }
}
