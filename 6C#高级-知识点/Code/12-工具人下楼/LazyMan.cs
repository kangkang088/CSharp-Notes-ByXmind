using System;
using System.Collections.Generic;
using System.Text;

namespace _12_工具人下楼
{
    internal class LazyMan
    {
        public string Name { get;private set; }

        public LazyMan(string name)
        {
            Name = name;
        }

        public void TakeFood()
        {
            Console.WriteLine("给" + Name + "拿外卖");
        }
        public void TakePackage()
        {
            Console.WriteLine("给" + Name + "拿快递");
        }

    }
}
