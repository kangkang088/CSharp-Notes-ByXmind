using System;
using Mynamespace2.ChildNamespace;

namespace Mynamespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Mynamespace2.ChildNamespace.Class2 c = new Mynamespace2.ChildNamespace.Class2();
            
        }
    }
}
