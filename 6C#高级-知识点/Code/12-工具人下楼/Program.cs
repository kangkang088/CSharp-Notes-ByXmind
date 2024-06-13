using System;

namespace _12_工具人下楼
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ToolMan toolMan = new ToolMan("小明");

            LazyMan lazyMan1 = new LazyMan("张三");
            LazyMan lazyMan2 = new LazyMan("李四");
            LazyMan lazyMan3 = new LazyMan("王五");


            toolMan.DownStairDelegate += lazyMan1.TakeFood;
            toolMan.DownStairDelegate += lazyMan2.TakePackage;
            toolMan.DownStairDelegate += lazyMan3.TakeFood;
            //toolMan.DownStairDelegate = lazyMan3.TakeFood;

            //toolMan.DownStair();

            //toolMan.DownStairDelegate -= lazyMan3.TakeFood;

            //toolMan.DownStair();

            //toolMan.DownStairDelegate();
        }
    }
}
