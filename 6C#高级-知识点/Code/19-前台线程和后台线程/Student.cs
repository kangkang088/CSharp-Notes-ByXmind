using System;
using System.Collections.Generic;
using System.Text;

namespace _19_前台线程和后台线程
{
    internal class Student
    {
        public int Age { get;  set; }
        public string Name { get;  set; }

        public Student(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public Student() { }
    }
}
