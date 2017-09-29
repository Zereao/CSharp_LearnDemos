using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 动物类的继承
{
    public class Cat : Animal
    {
        public new void Eat()
        {
            Console.WriteLine("Cat类 Eat函数");
        }

        public new void Shout()
        {
            Console.WriteLine("Cat类 Shout函数");
        }
    }
}
