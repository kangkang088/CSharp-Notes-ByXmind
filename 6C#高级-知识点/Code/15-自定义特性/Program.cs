using System;

namespace _15_自定义特性
{
    [Information("SiKi","v1.1","这个是用来发射核弹的类")]
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Program);

            bool result = t.IsDefined(typeof(InformationAttribute), false);
            Console.WriteLine(result);

            object[] attributeArray = t.GetCustomAttributes(false);
        }
    }
}
