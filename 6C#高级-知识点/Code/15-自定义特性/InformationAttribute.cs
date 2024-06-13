using System;
using System.Collections.Generic;
using System.Text;

namespace _15_自定义特性
{
    [AttributeUsage(AttributeTargets.Class)]
    internal sealed class InformationAttribute:Attribute
    {
        public string developer;
        public string version;
        public string description;

        public InformationAttribute(string developer, string version, string description)
        {
            this.developer = developer;
            this.version = version;
            this.description = description;
        }
    }
}
