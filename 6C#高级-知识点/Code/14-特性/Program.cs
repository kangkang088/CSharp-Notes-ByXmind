//#define IsShowMessage
//宏
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace _14_特性
{
    internal class Program
    {
        //[Obsolete("这个方法弃用了，请使用最新的NewTest方法")] //特性：弃用
        //static void Test()
        //{
        //    Console.WriteLine("test");
        //}
        //static void NewTest()
        //{
        //    Console.WriteLine("NewTest");
        //}
        //[Conditional("IsShowMessage")]
        //static void ShowMessage(string str)
        //{
        //    Console.WriteLine(str);
        //}
        [DebuggerStepThrough]
        static void ShowMessage(string message,[CallerLineNumber]int lineNumber=0,[CallerFilePath]string filePath="",[CallerMemberName]string memberName="") { 
            Console.WriteLine(message);
            Console.WriteLine(lineNumber);
            Console.WriteLine(filePath);
            Console.WriteLine(memberName);
        }


        static void Main(string[] args)
        {
            //Test();
            //Test();
            //ShowMessage("Start of Main");

            //Console.WriteLine("Doing work in main");

            //ShowMessage("End Of Main");

            ShowMessage("Hello");
        }
    }
}
