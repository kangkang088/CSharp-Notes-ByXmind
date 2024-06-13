using System;
using System.Collections.Generic;
using System.Text;

namespace _12_工具人下楼
{
    delegate void DownStairDelegate();
    internal class ToolMan
    {
        public string Name { get;private set; }
        //受限制的委托
        public event DownStairDelegate DownStairDelegate = null;

        public ToolMan(string name)
        {
            Name = name;
        }

        public void DownStair()
        {
            // dll  .exe
            Console.WriteLine("工具人" + Name + "下楼了");
            if(DownStairDelegate != null)
            {
                DownStairDelegate();
            }
        }

    }
}
