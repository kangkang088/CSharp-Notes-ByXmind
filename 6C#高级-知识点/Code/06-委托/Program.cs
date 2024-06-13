using System;

namespace _06_委托
{
    internal class Program
    {
        //delegate void IntMethodInvoker(int x);
        //delegate long TwoLong(long a,long b);
        //delegate string GetAString();

        static void Main(string[] args)
        {
            //IntMethodInvoker invoker = null;
            //TwoLong invoker2 = null;

            //invoker = Program.test;
            //invoker(100);
            //if(invoker2 != null)
            //{
            //    invoker2(2, 23);
            //}
            //int x = 1123;
            ////GetAString getAString = x.ToString;
            //GetAString getAString = new GetAString(x.ToString);
            //Console.WriteLine(getAString());

            DoubleOpDelegate[] operations = { MathOp.MultiplayByTwo, MathOp.Square };
            foreach(DoubleOpDelegate op in operations)
            {
                //Console.WriteLine(op(3));
                ProcessAndDisplayRes(op, 4);
            }
        }

        delegate double DoubleOpDelegate(double x);

        static void ProcessAndDisplayRes(DoubleOpDelegate op,double value)
        {
            double result = op(value);
            Console.WriteLine("Result:"+result);
        }

        //private static void test(int x)
        //{
        //    Console.WriteLine("我是test方法：" + x);
        //}
    }
}
