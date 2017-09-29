using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物类的继承
{
    public class Dog : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("Dog类 Eat函数");
        }

        public new void Shout()
        {
            Console.WriteLine("Dog类 Shout函数");
        }
    }
}
