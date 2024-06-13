using System;
using System.Collections.Generic;
using System.Text;
using Mynamespace;

// 
namespace Mynamespace2
{
    internal class Class1
    {
        private void test()
        {
            //Program p = new Program();
            //Mynamespace.Program p = new Mynamespace.Program();
            Program p = new Program();
            ChildNamespace.Class2 c = new ChildNamespace.Class2();
        }
    }
}
